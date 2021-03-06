﻿using COPSurvey.Data;
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
        private InUseDeviceRepository deviceRepository = null;

        public HomeController()
        {
            device = new InUseDevice();
            deviceRepository = new InUseDeviceRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string SerialNumber)
        {
            var inUseDevice = deviceRepository.GetInUseDevice(SerialNumber);
            if(inUseDevice == null)
            {
                return View();
            }
            return View("About", inUseDevice);
        }

        public ActionResult About()
        {
            return View(device);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}