using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodePond.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "The exciting place to fish for code games and activities and go on code adventures.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "is a series of games and activities to teach coding and the wider activity of software engineering. From algorithmic thinking to system design and testing, Code Pond is the place to dip in.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "is run by Rachel Jones.";

            return View();
        }


       
    }
}
