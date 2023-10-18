using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomePageController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Description = "Your one-stop solution for seamless registration and login.";

            return View();
        }
    }
}
