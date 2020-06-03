using Joole.Views.ProductVM;
using JooleCore;
using JooleRepo;
using System.Linq;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private UnitOfWork unitOfWork = new UnitOfWork();
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
        public ActionResult fanSummary(string id)
        {
            FanVM fanModel = new FanVM();
            fanModel.FanDetail = unitOfWork.FanRepository.Get(id);
            fanModel.ProductFanDetail = unitOfWork.ProductRepository.Get(id);
            return View(fanModel);
        }
        public ActionResult fanFilter(/*FormCollection col*/)
        {
            FanVM fanModel = new FanVM();
            fanModel.Fans = unitOfWork.FanRepository.GetAll();
            fanModel.Products = unitOfWork.ProductRepository.GetAll();
            return View(fanModel);
        }

        public ActionResult vacuumFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

    }
}