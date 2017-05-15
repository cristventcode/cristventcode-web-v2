using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cristventcode_web.Models;

namespace cristventcode_web.Controllers
{
    public class WritingController : Controller
    {
        public static ContentRepo _myWritings = new ContentRepo();
        // GET: Writing
        public ActionResult Index()
        {
            return View(_myWritings.getWritingAll());
        }

        // GET: Writing/Details/5
        public ActionResult Details(int id)
        {
            return View(_myWritings.getWritingById(id));
        }

        // GET: Writing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Writing/Create
        [HttpPost]
        public ActionResult Create(Writing newWriting, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                newWriting.Active = true;
                newWriting.LastEdit = newWriting.PostDate;
                _myWritings.createWriting(newWriting);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Writing/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_myWritings.getWritingById(id));
        }

        // POST: Writing/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Writing editedWriting, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _myWritings.editWriting(editedWriting);
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
