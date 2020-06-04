using Joole.Views.ProductVM;
using JooleRepo;
using System;
using System.Linq;
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
        public ActionResult fanSummary(string id)
        {
            FanVM fanModel = new FanVM();
            fanModel.FanDetail = unitOfWork.fanRepository.Get(id);
            fanModel.ProductFanDetail = unitOfWork.ProductRepository.Get(id);
            return View(fanModel);
        }
        public ActionResult fanFilter(FormCollection col)
        {
            if (col["year-min"] == null)
            {
                var t_prods = unitOfWork.ProductRepository.GetAll();
                var t_fans = unitOfWork.fanRepository.GetAll();
                var t_result = from p in t_prods
                               join f in t_fans on p.ModelNumber equals f.ModelNumber
                               select new { Manufacturer = p.Manufacturer, path = p.productImagePath, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Airflow = f.Airflow, PowerMax = f.PowerMax, SpeedSound = f.SpeedSound, SweepDiameter = f.SweepDiameter };
                ViewBag.result = t_result;
                return View(t_result);
            }

            //Model Year
            var year_min = float.Parse(col["year-min"]);
            var year_max = float.Parse(col["year-max"]);

            //Airflow
            var airflow_min = float.Parse(col["airflow-min"]);
            var airflow_max = float.Parse(col["airflow-max"]);

            //Max Power
            var power_min = float.Parse(col["power-min"]);
            var power_max = float.Parse(col["power-max"]);

            //Sound at max speed
            var sound_min = float.Parse(col["sound-min"]);
            var sound_max = float.Parse(col["sound-max"]);

            //fan sweep diameter
            var sweep_min = float.Parse(col["fan-diameter-min"]);
            var sweep_max = float.Parse(col["fan-diameter-max"]);


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
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, path = p.productImagePath, Airflow = f.Airflow, PowerMax = f.PowerMax, SpeedSound = f.SpeedSound, SweepDiameter = f.SweepDiameter };


            ViewBag.result = result;

            return View(result);
        }


        public ActionResult vacuumFilter(FormCollection col)
        {

            if (col["year-min"] == null)
            {
                var t_prods = unitOfWork.ProductRepository.GetAll();
                var t_vacs = unitOfWork.vacummRepository.GetAll();
                var t_result = from p in t_prods
                               join v in t_vacs on p.ModelNumber equals v.ModelNumber
                               select new { Manufacturer = p.Manufacturer, path = p.productImagePath, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Power = v.Power, Voltage = v.Voltage, CordLength = v.CordLength, Capacity = v.Capacity };
                ViewBag.result = t_result;
                return View(t_result);
            }

            var year_min = float.Parse(col["year-min"]);
            var year_max = float.Parse(col["year-max"]);

            var power_min = float.Parse(col["power-min"]);
            var power_max = float.Parse(col["power-max"]);

            var voltage_min = float.Parse(col["volt-min"]);
            var voltage_max = float.Parse(col["volt-max"]);

            var cord_min = float.Parse(col["cord-min"]);
            var cord_max = float.Parse(col["cord-max"]);

            var capacity_min = float.Parse(col["Capacity-min"]);
            var capacity_max = float.Parse(col["Capacity-max"]);


            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var vacs = unitOfWork.vacummRepository.GetAll();
            vacs = vacs.Where(x => float.Parse(x.Power) >= power_min);
            vacs = vacs.Where(x => float.Parse(x.Power) <= power_max);
            vacs = vacs.Where(x => float.Parse(x.Voltage) >= voltage_min);
            vacs = vacs.Where(x => float.Parse(x.Voltage) <= voltage_max);
            vacs = vacs.Where(x => float.Parse(x.CordLength) >= cord_min);
            vacs = vacs.Where(x => float.Parse(x.CordLength) <= cord_max);
            vacs = vacs.Where(x => float.Parse(x.Capacity) >= capacity_min);
            vacs = vacs.Where(x => float.Parse(x.Capacity) <= capacity_max);

            var result = from p in prods
                         join v in vacs on p.ModelNumber equals v.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, path = p.productImagePath, ModelNumber = p.ModelNumber, Power = v.Power, Voltage = v.Voltage, CordLength = v.CordLength, Capacity = v.Capacity };

            ViewBag.result = result;

            return View(result);
        }
        public ActionResult vacuumSummary(string id)
        {
            VacuumVM vacuumModel = new VacuumVM();
            vacuumModel.ProductVacDetail = unitOfWork.ProductRepository.Get(id);
            vacuumModel.VacDetail = unitOfWork.vacummRepository.Get(id);

            return View(vacuumModel);
        }
        public ActionResult couchFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var couches = unitOfWork.couchRepository.GetAll();

            var result = from p in prods
                         join c in couches on p.ModelNumber equals c.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, FillingMaterial = c.FillingMaterial, SurfaceMaterial = c.SurfaceMaterial, Dimension = c.Dimension };

            ViewBag.result = result;
            return View(result);
        }
        public ActionResult couchSummary(string id)
        {
            CouchVM couchModel = new CouchVM();
            couchModel.ProductCouchDetail = unitOfWork.ProductRepository.Get(id);
            couchModel.CouchDetail = unitOfWork.couchRepository.Get(id);

            return View(couchModel);
        }
        public ActionResult tableFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var tables = unitOfWork.tableRepository.GetAll();

            var result = from p in prods
                         join t in tables on p.ModelNumber equals t.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Material = t.Material, Style = t.Style, Dimension = t.Dimension };


            return View("ProductSummary");
        }

        public ActionResult tablesawFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var power_min = 0.0;
            var power_max = 9999.9;

            var volt_min = 0.0;
            var volt_max = 9999.9;

            var amp_min = 0.0;
            var amp_max = 9999.9;

            var speed_min = 0.0;
            var speed_max = 9999.9;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var saws = unitOfWork.tablesawRepository.GetAll();
            saws = saws.Where(x => float.Parse(x.Power) >= power_min);
            saws = saws.Where(x => float.Parse(x.Power) <= power_max);
            saws = saws.Where(x => float.Parse(x.Voltage) >= volt_min);
            saws = saws.Where(x => float.Parse(x.Voltage) <= volt_max);
            saws = saws.Where(x => float.Parse(x.Amperes) >= amp_min);
            saws = saws.Where(x => float.Parse(x.Amperes) <= amp_max);
            saws = saws.Where(x => float.Parse(x.Speed) >= speed_min);
            saws = saws.Where(x => float.Parse(x.Speed) <= speed_max);


            var result = from p in prods
                         join s in saws on p.ModelNumber equals s.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Power = s.Power, Voltage = s.Voltage, Amperes = s.Amperes, Speed = s.Speed };


            return View("ProductSummary");

        }
        public ActionResult workbenchFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var benches = unitOfWork.WorkbenchRepository.GetAll();

            var result = from p in prods
                         join b in benches on p.ModelNumber equals b.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Dimension = b.Dimension, SurfaceMaterial = b.SurfaceMaterial };

            return View("ProductSummary");
        }
        public ActionResult toasterFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var power_min = 0.0;
            var power_max = 9999.9;

            var volt_min = 0.0;
            var volt_max = 9999.9;

            var heat_min = 0.0;
            var heat_max = 9999.9;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var toasters = unitOfWork.toasterRepository.GetAll();
            toasters = toasters.Where(x => float.Parse(x.Power) >= power_min);
            toasters = toasters.Where(x => float.Parse(x.Power) <= power_max);
            toasters = toasters.Where(x => float.Parse(x.Voltage) >= volt_min);
            toasters = toasters.Where(x => float.Parse(x.Voltage) <= volt_max);
            toasters = toasters.Where(x => float.Parse(x.HeatingLevel) >= heat_min);
            toasters = toasters.Where(x => float.Parse(x.HeatingLevel) <= heat_max);


            var result = from p in prods
                         join t in toasters on p.ModelNumber equals t.ModelNumber
                         select new { Manufacturer = p.Manufacturer, ProductName = p.ProductName, ModelNumber = p.ModelNumber, Power = t.Power, Voltage = t.Voltage, HeatingLevel = t.HeatingLevel };

            return View("ProductSummary");
        }
        public ActionResult tvFilter(FormCollection col)
        {
            var year_min = 2018;
            var year_max = 2050;

            var power_min = 0.0;
            var power_max = 9999.9;

            var volt_min = 0.0;
            var volt_max = 9999.9;

            var screen_min = 0.0;
            var screen_max = 9999.9;

            var prods = unitOfWork.ProductRepository.GetAll();
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) >= year_min);
            prods = prods.Where(x => Convert.ToInt32(x.ModelYear) <= year_max);

            var tv = unitOfWork.tvRepository.GetAll();
            tv = tv.Where(x => float.Parse(x.Power) >= power_min);
            tv = tv.Where(x => float.Parse(x.Power) <= power_max);
            tv = tv.Where(x => float.Parse(x.Voltage) >= volt_min);
            tv = tv.Where(x => float.Parse(x.Voltage) <= volt_max);
            tv = tv.Where(x => float.Parse(x.ScreenSize) >= screen_min);
            tv = tv.Where(x => float.Parse(x.ScreenSize) <= screen_max);


            var result = from p in prods
                         join t in tv on p.ModelNumber equals t.ModelNumber
                         select (Manufacturer: p.Manufacturer, ProductName: p.ProductName, ModelNumber: p.ModelNumber, Power: t.Power, Voltage: t.Voltage, ScreenSize: t.ScreenSize, InputTypes: t.InputTypes, OutputTypes: t.OutputTypes);

            return View("ProductSummary");
        }

        public ActionResult testFilter(FormCollection col)
        {


            return View();
        }

        /* public static ExpandoObject ToExpando(this object anonymousObject)
         {
             IDictionary<string, object> anonymousDictionary = new RouteValueDictionary(anonymousObject);
             IDictionary<string, object> expando = new ExpandoObject();
             foreach (var item in anonymousDictionary)
                 expando.Add(item);
             return (ExpandoObject)expando;
         }*/
    }
}