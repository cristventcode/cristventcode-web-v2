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
                db.Entry(profile).Collection(item => item.Writings).Load();
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
                newWriting.ProfileId = 1;
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

        public void editWriting(Writing editedWriting)
        {
            using (var db = new ContentDbContext())
            {
                db.WritingsTable.Attach(editedWriting);
                db.Entry(editedWriting).State = EntityState.Modified;
                db.SaveChanges();
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
                var project = db.ProjectsTable.Find(id);
                db.Entry(project).Collection(item => item.SkillList).Load();
                return project;
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


        // Methods for Managing Skills
        public void createSkill(Skill newSkill)
        {
            newSkill.ProfileId = 1;
            using (var db = new ContentDbContext())
            {
                db.SkillsTable.Add(newSkill);
                db.SaveChanges();
            }
        }

        public List<Skill> getSkillAll()
        {
            using (var db = new ContentDbContext())
            {
                var skillList = from item in db.SkillsTable
                                  select item;

                return skillList.ToList();
            }
        }

        public Skill getSkillById(int id)
        {
            using (var db = new ContentDbContext())
            {
                return db.SkillsTable.Find(id);
            }
        }

        public void editSkill(Skill editedSkill)
        {
            using (var db = new ContentDbContext())
            {
                db.SkillsTable.Attach(editedSkill);
                db.Entry(editedSkill).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void deleteSkill(int skillId)
        {
            using (var db = new ContentDbContext())
            {
                var skill = db.SkillsTable.Find(skillId);
                db.SkillsTable.Remove(skill);
                db.SaveChanges();
            }
        }
        // End of Skills 
    }

}