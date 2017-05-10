using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cristventcode_web.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public int BioId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}