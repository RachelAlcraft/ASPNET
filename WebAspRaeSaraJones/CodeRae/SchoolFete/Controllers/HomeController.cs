using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolFete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Game1()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Game2()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Game3()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Game4()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Game5()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}