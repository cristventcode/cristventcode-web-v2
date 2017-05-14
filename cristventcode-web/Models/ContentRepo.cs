using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cristventcode_web.Models
{
    public class ContentRepo
    {

        // Methods for managing the profile
        public static List<Profile> _myProfile = new List<Profile>();

        public Profile getProfile()
        {
            using (var db = new ContentDbContext())
            {
                var profile = db.ProfileTable.Find(1);
                db.Entry(profile).Collection(item => item.Projects).Load();
                return profile;
            }
        }

        public void createProfile(Profile newProfile)
        {
            using (var db = new ContentDbContext())
            {
                db.ProfileTable.Add(newProfile);
                db.SaveChanges();
            }
        }
        // End of Profile 


        // Methods for managing Writings
        public void createWriting(Writing newWriting)
        {
            using (var db = new ContentDbContext())
            {
                db.WritingsTable.Add(newWriting);
                db.SaveChanges();
            }
        }

        public List<Writing> getWritingAll()
        {
            using (var db = new ContentDbContext())
            {
                var writingList = from item in db.WritingsTable
                                  select item;

                return writingList.ToList();
            }
        }

        public Writing getWritingById(int id)
        {
            using (var db = new ContentDbContext())
            {
                return db.WritingsTable.Find(id);
            }
        }
        // End of Writings


        // Methods for managing Projects
        public void createProject(Project newProject)
        {
            newProject.ProfileId = 1;
            using (var db = new ContentDbContext())
            {       
                db.ProjectsTable.Add(newProject);
                db.SaveChanges();
            }
        }

        public List<Project> getProjectAll()
        {
            using (var db = new ContentDbContext())
            {
                var projectList = from item in db.ProjectsTable
                                  select item;

                return projectList.ToList();
            }
        }

        public Project getProjectById(int id)
        {
            using (var db = new ContentDbContext())
            {
                return db.ProjectsTable.Find(id);
            }
        }

        public void editProject(Project editedProject)
        {
            using(var db = new ContentDbContext())
            {
                db.ProjectsTable.Attach(editedProject);
                db.Entry(editedProject).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        // End of Projects

    }

}