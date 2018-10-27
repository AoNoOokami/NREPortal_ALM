using System.Collections.Generic;
using System.Web.Mvc;
using Main.Models;

namespace Main.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Biogas()
        {
            return View();
        }

        public ActionResult Hydraulic()
        {
            return View();
        }

        public ActionResult Windturbine()
        {
            return View();
        }

        public JsonResult WindturbineChart()
        {
            // Bug 341 corrected (bug added in InProgess Work)
            Models.Chart _chart = new Models.Chart();
            _chart.labels = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            _chart.datasets = new List<Dataset>();
            List<Dataset> _dataSet = new List<Dataset>();
            _dataSet.Add(new Dataset()
            {
                label = "Production [kWh]",
                data = new int[] { 28, 48, 40, 19, 86, 27, 90, 20, 45, 65, 34, 22 },
                borderColor = new string[] { "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf", "#0364bf" },
                backgroundColor = new string[] { "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5", "#9ac1e5" },
                borderWidth = "1"
            });
            _chart.datasets = _dataSet;
            return Json(_chart, JsonRequestBehavior.AllowGet);
        }
    }
}