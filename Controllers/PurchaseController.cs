using MedsOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MedsOnline.General;
using MedsOnline.Data;
using MedsOnline.Models;

namespace MedsOnline.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public PurchaseController(ApplicationDbContext mc)
        {
            _Context = mc;
        }
        public IActionResult PurchaseForm()
        {
            return View("PurchaseForm");
        }
         public IActionResult PurchaseDetails()
        {
            return View("PurchaseDetails");
        }

        [HttpPost]
        public Response SetPurchase(tbPurchaseHeader Header, List<tbPurchaseDetails> Details)
        {
            // Declearation 
            Response ObjReturn = new Response();

           try
            {
                Header.CreatedBy = 1;
                Header.CreatedOn = DateTime.Now;
              
                //Prurchase Header Save
               _Context.Add(Header);
               _Context.SaveChanges();          
       
                //Purchase Details save
                for(var i=0; i < Details.count; i++)
                {
                    _Context.Add(Details.[i]);
                    _Context.SaveChanges(); 
                }
                ObjReturn.Status = "Success";
                ObjReturn.Message = "Purchase Added Sucessfully";
                ObjReturn.Result = Header.GRNID;
            }
            catch (Exception ex)
            {
                ObjReturn.Status = "Failure";
                ObjReturn.Message = ex.Message;
                ObjReturn.Result = null;
            }           
            return ObjReturn;
        }

//Get Purchase Details
         [HttpPost]
        public Response GetPurchase(int GRNID)
        {
            Response ObjReturn = new Response();

            try
            {
                var ListPurchase = _Context.tbPurchaseDetails.Where(F => F.GRNID == GRNID);
                ObjReturn.Status = "Success";
                ObjReturn.Message = "Purchase Details collected Successfully";
                ObjReturn.Result = ListPurchase;

            }
            catch (Exception ex)
            {
                ObjReturn.Status = "Failure";
                ObjReturn.Message = ex.Message;
                ObjReturn.Result = null;
            }
            return ObjReturn;
        }

    }
}
