using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeStory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }

        public ActionResult Teachers()
        { 
             ViewBag.Message = "Teachers' Page.";

            return View();
        }

        public ActionResult SchoolFete()
        {
            ViewBag.Message = "School Fete";

            return View();
        }

        public ActionResult Activities()
        {
            ViewBag.Message = "Kids' Page";

            return View();
        }

        public ActionResult Masters()
        {
            ViewBag.Message = "Masters' Dissertation";

            return View();
        }

        public ActionResult Paper()
        {
            ViewBag.Message = "Paper Versions";

            return View();
        }
        public ActionResult Before()
        {
            ViewBag.Message = "Before Quiz";

            return View();
        }
        public ActionResult After()
        {
            ViewBag.Message = "After Quiz";

            return View();
        }
        public ActionResult Confidentiality()
        {
            ViewBag.Message = "Confidentiality";

            return View();
        }
        public ActionResult Requirements()
        {
            ViewBag.Message = "Requirements";

            return View();
        }
        public ActionResult Design()
        {
            ViewBag.Message = "Design";

            return View();
        }
        public ActionResult Documentation()
        {
            ViewBag.Message = "Documentation";

            return View();
        }



    }
}