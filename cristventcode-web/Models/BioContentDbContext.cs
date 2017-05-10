using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cristventcode_web.Models
{
    public class BioContentDbContext : DbContext
    {
        public DbSet<Bio> BioTable { get; set; }
        public DbSet<Link> LinksTable { get; set; }
        public DbSet<Project> ProjectsTable { get; set; }
    }
}