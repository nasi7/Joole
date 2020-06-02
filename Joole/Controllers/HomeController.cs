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

        public ActionResult Signup()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult doSignup(FormCollection col)
        {
            //ViewBag.Message = "Your contact page.";
            var user_name = col["userName"];
            var user_email = col["email"];
            var user_password = col["userPass"];
            var user_confirmPass = col["confirmPass"];

            return View();
        }

        public ActionResult Search()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult doSearch(FormCollection col)
        {
            //ViewBag.Message = "Your contact page.";

            var sub = col["subCategory"];
            System.Diagnostics.Debug.WriteLine("\ndoSearch called!\n");
  

            return View("search");
        }

    }
}