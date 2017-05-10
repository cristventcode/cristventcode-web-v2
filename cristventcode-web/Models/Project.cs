using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int BioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Link> Links { get; set; }
        public List<string> ToolsUsed { get; set; }
    }
}