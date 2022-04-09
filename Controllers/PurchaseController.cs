using MedsOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MedsOnline.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult PurchaseForm()
        {
            return View("PurchaseForm");
        }
           public IActionResult PurchaseDetails()
        {
            return View("PurchaseDetails");
        }

    }
}
