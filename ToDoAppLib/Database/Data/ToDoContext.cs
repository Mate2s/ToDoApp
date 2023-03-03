using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppLib.Database.Models;
using ToDoAppLib.Enums;

namespace ToDoAppLib.Database.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }

    }
}
