﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cristventcode_web.Models;

namespace cristventcode_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Skills()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

    }
}