using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppLib.Database;
using ToDoAppLib.Enums;

namespace ToDoAppLib.Iterface
{
    public interface IToDoTask
    {
        [DisplayName("Jméno úkolu")]
        public string Name { get; set; }
        [DisplayName("Stav")]
        public State State { get; set; }
        [DisplayName("Termín")]
        public DateTime? Deadline { get; set; }
    }
}
