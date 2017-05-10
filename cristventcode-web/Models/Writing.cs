using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Writing
    {
        public int WritingId { get; set; }
        public int ProfileId { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime LastEdit { get; set; }
        public string ExternalUrl { get; set; }
        public string Content { get; set; }
    }
}