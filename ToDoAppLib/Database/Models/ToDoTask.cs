using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppLib.Enums;
using ToDoAppLib.Iterface;

namespace ToDoAppLib.Database.Models
{
    public class ToDoTask : IToDoTask
    {
        [Key]
        public int IdToDoTask { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public Priority Priority { get; set; }
        [Required]
        public State State { get; set; }
        public DateTime? Deadline { get; set; }
        public string? Description { get; set; }

        public string Username { get; set; }
        public virtual User User { get; set; }
    }
}
