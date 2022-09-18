using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAspRaeSaraJones.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "...about";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "...contact";

            return View();
        }
    }
}