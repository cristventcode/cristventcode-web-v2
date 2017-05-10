using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cristventcode_web.Models;

namespace cristventcode_web.Controllers
{
    public class ProfileController : Controller
    {
        private static ContentRepo _myProfile = new ContentRepo();
        // GET: Content
        public ActionResult Index()
        {
            return View(_myProfile.getProfile());
        }

        // GET: Content/Details/5
        public ActionResult Details()
        {
            return View(_myProfile.getProfile());
        }

        // GET: Content/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Content/Create
        [HttpPost]
        public ActionResult Create(Profile newProfile, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _myProfile.createProfile(newProfile);
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Content/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Content/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Content/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Content/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
