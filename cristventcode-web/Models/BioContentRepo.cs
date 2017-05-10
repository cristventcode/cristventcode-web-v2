using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class BioContentRepo
    {
        public static List<Bio> _myBio = new List<Bio>();

        public BioContentRepo()
        {

        }

        public Bio getBio()
        {
            using(var db = new BioContentDbContext())
            {
                return db.BioTable.Find(1);              
            }
        }

        public void CreateBio(Bio newBio)
        {
            using(var db = new BioContentDbContext())
            {
                db.BioTable.Add(newBio);
                db.SaveChanges();
            }
        }

    }

}