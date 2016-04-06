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
            List<Task> currentTasks;
            currentTasks = (List<Task>)Session["tasks"] ?? new List<Task>();
            //List<Task> task = new List<Task>()
            //{
            //    new Task(1, "Seth Quaye", "Go Home", false),
            //    new Task(2, "Seth Quaye", "Eat Lunch", true),
            //};

            return View(currentTasks);
        }

        //Post Task
        [HttpGet]
        public ActionResult Create()
        { 
            return View();
        }

        //Post Task
        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            if (ModelState.IsValid)
            {
                var currentTasks = (List<Task>)Session["tasks"];
                if (currentTasks == null)
                {
                    currentTasks = new List<Task>();
                }
                currentTasks.Add(newTask);

                Session["tasks"] = currentTasks;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}