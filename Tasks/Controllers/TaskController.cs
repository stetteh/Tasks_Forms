using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            List<Task> task = new List<Task>()
            {
                new Task(1, "Seth Quaye", "Go Home", false),
                new Task(2, "Seth Quaye", "Eat Lunch", true),
            };

            return View(task);
        }

        //Post Task
        [HttpPost]
        public ActionResult Create()
        {

            return Index();
        }
    }
}