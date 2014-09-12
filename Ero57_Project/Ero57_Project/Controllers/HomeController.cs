﻿using Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ero57_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersistenceService _service;
        public HomeController(IPersistenceService service)
        {
            _service = service;
        }
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
    }
}