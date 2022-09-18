using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodePond.BusinessObjects;

namespace CodePond.Controllers
{
    public class ChoiceController : Controller
    {
        //
        // GET: /Choice/

        


        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
       

        public ActionResult Princess()
        {
            ViewBag.Message = "Hello!";
            ViewBag.NumTimes = 4;
            ViewBag.NumTesters = 2;
            ViewBag.Princess = "Primavera";
            PrincessTester one = new PrincessTester();
            one.IsPrincess = true;
            one.Name = "Princess Primavera";
            PrincessTester two = new PrincessTester();
            two.Name = "Jack";
            //PrincessTesters.GetInstance.Testers.Add(one);
            //PrincessTesters.GetInstance.Testers.Add(two);
            ViewBag.Testers = PrincessTesters.GetInstance.Testers;

            return View();
        }

        public ActionResult AddTester(string testerName)
        {
            PrincessTester pt = new PrincessTester();
            pt.Name = testerName;
            //PrincessTesters.GetInstance.Testers.Add(pt);            
            ViewBag.Testers = PrincessTesters.GetInstance.Testers;
            ViewBag.NumTesters = PrincessTesters.GetInstance.Testers.Count;
            return View();
        }

        public ActionResult PrincessTest(string color1, string like)
        {
            ViewBag.Message = "Hello!";
            ViewBag.NumTimes = 4;
            return View();
        }

    }
}
