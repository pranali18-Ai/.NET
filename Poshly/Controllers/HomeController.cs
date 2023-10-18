using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poshly.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            //ViewBag.Countries = new List<string>()
            ViewData["Countries"] = new List<string>()
            {
                "India",
                 "UK",
                 "Canada",
                 "US"
            };
            return View();
        }
        
        }
    }
