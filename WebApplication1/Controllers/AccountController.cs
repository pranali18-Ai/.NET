using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Web.Mvc;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {

        public OurDbContext dbContext = new OurDbContext();


        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserAccount registerdetails)
        {
            if (ModelState.IsValid)
            {

                if (dbContext.UserAccount.Any(u => u.UserName == registerdetails.UserName))
                {
                    ModelState.AddModelError("UserName", "Username already taken.");
                    return View(registerdetails);
                }


                UserAccount newUser = new UserAccount
                {
                    Name = registerdetails.Name,
                    DOB = registerdetails.DOB,
                    UserName = registerdetails.UserName,
                    Password = registerdetails.Password,
                    Gender = registerdetails.Gender,
                    UserType = registerdetails.UserType
                };


                dbContext.UserAccount.Add(newUser);
                dbContext.SaveChanges();
                ModelState.Clear();
                TempData["Success"] = "Registration succesful ! You can now login";
                return RedirectToAction("Login", "Account");
            }

            return View(registerdetails);

        }
        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }


        [HttpPost]

        public ActionResult Login(UserAccount loginDetails)
        {
            using (OurDbContext db = new OurDbContext())
            {


                var user = dbContext.UserAccount.FirstOrDefault(u => u.UserName == loginDetails.UserName && u.Password == loginDetails.Password);
                if (user != null)
                {
                    Session["Id"] = user.Id.ToString();
                    Session["Name"] = user.Name.ToString();

                    if (user.UserType == "Admin")
                    {
                        return RedirectToAction("AdminDash", "Dashes");
                    }
                    else
                    {
                        return RedirectToAction("UserDash", "Dashes");
                    }
                }


                ModelState.AddModelError("", "Invalid username or password.");
                return View();
            }


        }

    }
}




