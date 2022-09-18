using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeStory.Controllers
{
    public class MastersController : Controller
    {
        // GET: Masters
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Methodology()
        {
            return View();
        }
        public ActionResult Technology()
        {
            return View();
        }
        public ActionResult CompThinking()
        {
            return View();
        }
        public ActionResult Literature()
        {
            return View();
        }
    }
}