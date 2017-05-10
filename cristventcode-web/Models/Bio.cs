using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Bio
    {
        public int BioId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string BioText { get; set; }
        public string Image { get; set; }
        public List<Link> Links { get; set; }
        public List<Project> Projects { get; set; }
    }
}