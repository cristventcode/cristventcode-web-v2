using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cristventcode_web.Controllers
{
    public class WritingController : Controller
    {
        // GET: Writing
        public ActionResult Index()
        {
            return View();
        }

        // GET: Writing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Writing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Writing/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Writing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Writing/Edit/5
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

        // GET: Writing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Writing/Delete/5
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
