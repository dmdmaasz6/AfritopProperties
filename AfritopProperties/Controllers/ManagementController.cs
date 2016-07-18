using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfritopProperties.Controllers
{
    public class ManagementController : Controller
    {
        //
        // GET Projects: /Management/
        public ActionResult ViewProjects()
        {
            return View();
        }

        //
        // ADD Projects: /Management/
        public ActionResult AddProject()
        {
            return View();
        }
	}
}