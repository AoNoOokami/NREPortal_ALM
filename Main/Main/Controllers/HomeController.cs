using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Main.Controllers
{
    public class HomeController : Controller

        //ALM first commit (AZ)
        //pouet2 to
        //TEST 3 DC
    {
        private NRE_Portal_DBModelContainer db = new NRE_Portal_DBModelContainer();
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

        //Test UserStory Page
        public ActionResult Test()
        {
            return View("Test");
        }

        //Test UserStory Create Action
        public ActionResult CreateTest(PrivateInstallationTest pi)
        {
            //ToDo: Check null and validity of data sent
            db.PrivateInstallationTestSet.Add(pi);
            db.SaveChanges();
            //await db.SaveChangesAsync();
            return View("Index");
        }
    }
}