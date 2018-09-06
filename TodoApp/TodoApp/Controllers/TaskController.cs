using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController()
        {
            _context=new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Task
        public ActionResult Index()
        {
            var list = _context.Taskses.ToList();
            return View(list);
        }

        [HttpPost]
        public ActionResult Save(Tasks tasks)
        {
            if (tasks.Id == 0)
            {
                _context.Taskses.Add(tasks);
            }
            else
            {
                var recordInDb = _context.Taskses.Single(i => i.Id == tasks.Id);
                recordInDb.TaskName = tasks.TaskName;
                recordInDb.Description = tasks.Description;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Task");
        }

        public ActionResult New()
        {
            return View();
        }

 

        public ActionResult Update(int id)
        {
            var recordInDb = _context.Taskses.Single(i => i.Id==id);
            return View(recordInDb);
        }
        
    }
}