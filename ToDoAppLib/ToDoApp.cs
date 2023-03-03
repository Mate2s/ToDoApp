using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToDoAppLib.Database.Data;
using ToDoAppLib.Database.Models;
using ToDoAppLib.Enums;
using ToDoAppLib.Iterface;

namespace ToDoAppLib
{
    public class ToDoApp
    {
        public User User { get; set; }
        public List<ToDoTask> ActualTasks { get; set; }
        public ToDoApp()
        {

        }

        public void InitDB()
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    var query = from user in db.Users
                                select user;
                    if (query.Count() == 0)
                    {
                        var user = new User { Username = "admin", Password = "admin", Email = "test@test.cz" };
                        db.Users.Add(user);
                        db.ToDoTasks.Add(new ToDoTask
                        {
                            Username = user.Username,
                            Name = "ToDoApp",
                            Priority = Priority.High,
                            State = State.InProgress,
                            Deadline = new DateTime(2023, 3, 3, 11, 0, 0),
                            Description = "Úkolem je vytvořit jednoduchou desktopovou aplikaci pro vedení ToDo listu. Do aplikace se uživatel bude moci\r\npřihlásit za pomoci uživatelského jména a hesla. Po přihlášení uživatel uvidí seznam vlastních úkolů spolu s\r\nmožnosti otevření detailu. Na seznamu úkolů budou tyto informace: název úkolu, datům do kdy se má úkol splnit\r\n(pokud se jedná o úkol s termínem splnění) a možnost úkol splnit. Pokud je úkol již po termínu, tak bude zvýrazněn.\r\nPo rozkliknuti úkolů půjde úkol změnit a uložit. Detail úkolu bude obsahovat: název úkolu, datům do kdy se má\r\nsplnit, případně popis a prioritu."
                        });
                    }
                    db.SaveChanges();
                }
            }
            catch
            {

            }

        }

        public bool Login(string name, string password)
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    var user = (from u in db.Users
                                where u.Username == name
                                select u).FirstOrDefault();
                    if (user == null)
                        return false;
                    if (password == user.Password)
                    {
                        User = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public List<IToDoTask> GetToDoTasks()
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    var tasks = (from t in db.ToDoTasks
                                 where t.Username == User.Username
                                 select t).ToList<IToDoTask>();
                    return tasks;
                }
            }
            catch
            {
                return null;
            }
        }

        public void SetToDoTasks()
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    ActualTasks = (from t in db.ToDoTasks
                                   where t.Username == User.Username
                                   select t).ToList();
                }
            }
            catch
            {
            }
        }

        public void Delete(ToDoTask toDoTask)
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    var itemToRemove = db.ToDoTasks.SingleOrDefault(x => x.IdToDoTask == toDoTask.IdToDoTask);

                    if (itemToRemove != null)
                    {
                        db.ToDoTasks.Remove(itemToRemove);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                // throw new Exception("DB - delete failed");
            }
        }

        public void Insert(ToDoTask toDoTask)
        {
            try
            {
                using (var db = new ToDoContext())
                {
                    db.ToDoTasks.Add(toDoTask);
                    db.SaveChanges();
                }
            }
            catch
            {
                // throw new Exception("DB - insert failed");
            }
        }

    }
}
