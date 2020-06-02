using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }

        public ActionResult Compare()
        {
            return View();
        }

        public ActionResult ProductSummary()
        {
            return View();
        }

        public ActionResult fanFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

        public ActionResult vacuumFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

    }
}