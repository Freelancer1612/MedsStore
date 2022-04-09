using MedsOnline.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MedsOnline.Controllers
{
public class CustomerController : Controller
{
//Add and Edit
public IActionResult CustomerAdd()
{

    return View("CustomerAdd");
}
//Customers details
public IActionResult CustomerView()
{

    return View("CustomerView");
}

}

}