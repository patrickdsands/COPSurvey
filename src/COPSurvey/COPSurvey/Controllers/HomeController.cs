using COPSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COPSurvey.Controllers
{
    public class HomeController : Controller
    {
        InUseDevice device = null;

        public HomeController()
        {
            device = new InUseDevice();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string SerialNumber)
        {
            var inUseDevice = new InUseDevice(SerialNumber);
            return View("About",inUseDevice);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}