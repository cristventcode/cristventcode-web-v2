using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string BioText { get; set; }
        public string Image { get; set; }
        public List<Project> Projects { get; set; }
        public List<Writing> Writings { get; set; }
    }
}