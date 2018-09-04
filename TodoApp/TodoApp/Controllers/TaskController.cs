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
        // GET: Task
        public ActionResult Index()
        {
            var list = _context.Taskses.ToList();
            return View(list);
        }
    }
}