using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NETmovies.Models;

namespace NETmovies.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Title = "Shrek!" };
            //ViewData["Movie"] = movie;
            return View();
        }
    }
}