using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int ProfileId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string GithubUrl { get; set; }
        public string InternalUrl { get; set; }
        public string ToolsUsed { get; set; }
        public bool Active { get; set; }
    }
}