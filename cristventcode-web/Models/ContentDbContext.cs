using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cristventcode_web.Models
{
    public class ContentDbContext : DbContext
    {
        public DbSet<Profile> ProfileTable { get; set; }
        public DbSet<Project> ProjectsTable { get; set; }
        public DbSet<Writing> WritingsTable { get; set; }

    }
}