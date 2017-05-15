using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cristventcode_web.Models;

namespace cristventcode_web.Controllers
{
    public class ProjectController : Controller
    {
        public static ContentRepo _myProjects = new ContentRepo();
        // GET: Project
        public ActionResult Index()
        {
            return View(_myProjects.getProjectAll());
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            return View(_myProjects.getProjectById(id));
        }

        public ActionResult Skills(int id)
        {
            Project targetProject = _myProjects.getProjectById(id);
            ViewBag.ProjectId = targetProject.ProjectId;
            ViewBag.ProjectTitle = targetProject.Title;
            return View(targetProject.SkillList);
        }

        [HttpPost]
        public ActionResult Skills(Skill newSkill)
        {
            newSkill.ProfileId = 1;
            newSkill.Active = true;
            _myProjects.createSkill(newSkill);
            return RedirectToAction("Skills", new { id = newSkill.ProjectId });
        }

        public ActionResult DeleteSkill(int id)
        {
            Skill targetSkill = _myProjects.getSkillById(id);
            _myProjects.deleteSkill(id);
            return RedirectToAction("Skills", new { id = targetSkill.ProjectId });
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(Project newProject, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                newProject.Active = true;
                _myProjects.createProject(newProject);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_myProjects.getProjectById(id));
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Project editedProject, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                _myProjects.editProject(editedProject);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_myProjects.getProjectById(id));
        }

        // POST: Project/Delete/5
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
