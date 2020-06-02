using JooleCore;
using JooleRepo;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class HomeController : Controller
    {

        //private JooleDatabaseEntities db = new JooleDatabaseEntities();
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

            var user_confirmPass = col["confirmPass"];
            var user_image = col["userImage"];

            User user = new User();
            user.Email = col["email"];
            user.Password = col["userPass"];
            user.Username = col["userName"];

            unitOfWork.UserRepository.Add(user);
            unitOfWork.Complete();

            return View("search");
            //return RedirectToAction("Index", "Users");
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

            /*var sub = col["subCategory"];*/

            string sub = "TableSaws";
            System.Diagnostics.Debug.WriteLine("\ndoSearch called!\n");

            Product prod = new Product();

            var prods = unitOfWork.ProductRepository.Find(product => product.SubCategory == sub);

            /*System.Diagnostics.Debug.WriteLine(prods.ToList()[0]);*/

            /*foreach (var p in prods) {*/
            //System.Diagnostics.Debug.WriteLine(prods.ToList()[0].ProductName);


            return View("search");
        }

    }
}