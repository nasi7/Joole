using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleCore;
using JooleRepo;

namespace Joole.Controllers
{
    public class HomeController : Controller
    {
        //private JooleDatabaseEntities db = new JooleDatabaseEntities();
        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            return View();
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

            var user_confirmPass = col["confirmPass"];
            var user_image = col["userImage"];

            User user = new User();
            user.Email = col["email"];
            user.Password = col["userPass"];
            user.Username = col["userName"];

            unitOfWork.UserRepository.Add(user);
            unitOfWork.Complete();

            return View("search");
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