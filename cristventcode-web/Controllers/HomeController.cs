using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cristventcode_web.Models;

namespace cristventcode_web.Controllers
{
    public class HomeController : Controller
    {
        private static ContentRepo _myProfile = new ContentRepo();
        public ActionResult Index()
        {
            return View(_myProfile.getProfile());
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