using JooleCore;
using JooleRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole.Controllers
{
    public class ProductController : Controller
    {

        UnitOfWork unitOfWork = new UnitOfWork();

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
            /*
            //Model Year
            var year_min = float.Parse(col[""]);
            var year_max = float.Parse(col[""]);

            //Airflow
            var airflow_min = float.Parse(col[""]);
            var airflow_max = float.Parse(col[""]);

            //Max Power
            var power_min = float.Parse(col[""]);
            var power_max = float.Parse(col[""]);

            //Sound at max speed
            var sound_min = float.Parse(col[""]);
            var sound_max = float.Parse(col[""]);

            //fan sweep diameter
            var sweep_min = float.Parse(col[""]);
            var sweep_max = float.Parse(col[""]);
*/
            //dummy******************
            var year_min = 2018;
            var year_max = 2050;

            var airflow_min = 0.0;
            var airflow_max =9999.0;

            //Max Power
            var power_min = 0.0;
            var power_max = 9999.0;

            //Sound at max speed
            var sound_min = 0.0;
            var sound_max = 9999.0;

            var sweep_min = 0.0;
            var sweep_max = 9999.0;

            //************************
            //filter on products table
            /*var prods = unitOfWork.ProductRepository.Find(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);*/

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            //filter on fan table
            var fans = unitOfWork.fanRepository.GetAll();
            fans = fans.Where(x => float.Parse(x.Airflow) >= airflow_min);
            fans = fans.Where(x => float.Parse(x.Airflow) <= airflow_max);
            fans = fans.Where(x => float.Parse(x.PowerMax) >= power_min);
            fans = fans.Where(x => float.Parse(x.PowerMax) <= power_max);
            fans = fans.Where(x => float.Parse(x.SpeedSound) >= sound_min);
            fans = fans.Where(x => float.Parse(x.SpeedSound) <= sound_max);
            fans = fans.Where(x => float.Parse(x.SweepDiameter) >= sweep_min);
            fans = fans.Where(x => float.Parse(x.SweepDiameter) <= sweep_max);

            var result = from p in prods
                         join f in fans on p.ModelNumber equals f.ModelNumber
                         select new  { Manufacturer=p.Manufacturer, ProductName=p.ProductName,ModelNumber=p.ModelNumber, Airflow=f.Airflow, PowerMax = f.PowerMax, SpeedSound=f.SpeedSound,SweepDiameter=f.SweepDiameter};
            
            foreach ( Fan p in fans)
            {
                System.Diagnostics.Debug.WriteLine(p.ModelNumber);
            }

            return View("testFilter");
        }



        public ActionResult vacuumFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

        public ActionResult couchFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

        public ActionResult tableFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

        public ActionResult tablesawFilter(FormCollection col)
        {


            return View("ProductSummary");
        }
        public ActionResult workbenchFilter(FormCollection col)
        {


            return View("ProductSummary");
        }
        public ActionResult toasterFilter(FormCollection col)
        {


            return View("ProductSummary");
        }
        public ActionResult tvFilter(FormCollection col)
        {


            return View("ProductSummary");
        }

        public ActionResult testFilter(FormCollection col)
        {


            return View();
        }
    }
}