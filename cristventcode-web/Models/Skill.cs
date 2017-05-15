using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int ProfileId { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string RelevantWorkUrl { get; set; }
        public bool Active { get; set; }
    }
}