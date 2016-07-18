using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfritopProperties.Models
{
    public class Projects
    {

        public string name { get; set; }
        public string description { get; set; }
        public string project_type { get; set; }
        public List<HttpPostedFileBase> images { get; set; }

    }
}