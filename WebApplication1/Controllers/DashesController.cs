using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DashesController : Controller
    {
        // GET: Dashes
        public OurDbContext dbContext = new OurDbContext();
        public ActionResult UserDash()
        {
            return View();
        }
        public ActionResult AdminDash()
        {
            var users = dbContext.UserAccount.ToList();
            return View(users);
        }
    }
}