using JooleCore;
using JooleRepo;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            User validUser = unitOfWork.UserRepository.Get(username);
            if (validUser != null && validUser.Password == password)
            {
                return RedirectToAction("Index", "Users");
            }
            else
            {
                TempData["invalidUserMessage"] = "<script>alert('Invalid Username or Password');</script>";
                return RedirectToAction("Index");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }
    }
}