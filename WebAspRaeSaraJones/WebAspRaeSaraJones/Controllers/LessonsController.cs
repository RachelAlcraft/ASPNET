using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAspRaeSaraJones.Controllers
{
    [Authorize]
    public class LessonsController : Controller
    {
        // GET: Lessons
        public ActionResult Lessons()
        {
            return View();
        }
    }
}