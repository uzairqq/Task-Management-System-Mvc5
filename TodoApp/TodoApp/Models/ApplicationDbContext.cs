using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("TodoApp")
        {
        }

        public DbSet<Tasks> Taskses { get; set; }

    }
}