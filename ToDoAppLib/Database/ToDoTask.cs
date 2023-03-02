using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppLib.Enums;
using ToDoAppLib.Iterface;

namespace ToDoAppLib.Database
{
    public class ToDoTask : IToDoTask
    {
        [Key]
        public int IdToDoTask { get; set; }
        public string Name { get; set; }
        public Priority Priority { get; set; }
        public State State { get; set; }
        public DateTime? Deadline { get; set; }
        public string? Description { get; set; }

        public string Username { get; set; }
        public virtual User User { get; set; }
    }
}
