using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Task> task = new List<Task>()
            {
                new Task(1, "Seth Quaye", "Go Home", false),
                new Task(2, "Seth Quaye", "Eat Lunch", true),
            };

            return View(task);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}