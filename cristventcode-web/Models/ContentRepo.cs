using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class ContentRepo
    {
        public static List<Profile> _myProfile = new List<Profile>();

        public Profile getProfile()
        {
            using(var db = new ContentDbContext())
            {
                return db.ProfileTable.Find(1);              
            }
        }

        public void CreateBio(Profile newProfile)
        {
            using(var db = new ContentDbContext())
            {
                db.ProfileTable.Add(newProfile);
                db.SaveChanges();
            }
        }

    }

}