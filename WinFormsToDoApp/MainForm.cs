using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppLib;
using ToDoAppLib.Database;
using ToDoAppLib.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsToDoApp
{
    public partial class MainForm : Form
    {
        public ToDoApp ToDoApp = new ToDoApp();
        public MainForm()
        {
            InitializeComponent();
            ToDoApp.InitDB();

            login();

            RefreshUI();
        }

        private void login()
        {
            LoginForm loginForm = new LoginForm(this);
            if (loginForm.ShowDialog(this) != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            loginForm.Dispose();
        }

        public void RefreshUI()
        {
            userLabel.Text = ToDoApp.User.Username;
            ToDoApp.SetToDoTasks();
            var tasks = ToDoApp.GetToDoTasks();
            mainDataGridView.DataSource = tasks;

            int completedTasks = tasks.Where(x => x.State == State.Done).Count();
            completedTasksLable.Text = completedTasks.ToString();

            int tasksInProgress = tasks.Where(x => x.State == State.InProgress).Count();
            tasksInProgressLabel.Text = tasksInProgress.ToString();

            checkDeadline();

        }
        public string GetTaskName()
        {
            return mainDataGridView.SelectedCells[0].Value.ToString();
        }


       

        private void detailButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new(this);
            detailForm.Show(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new(this);
            detailForm.Clean();
            detailForm.Insert = true;
            detailForm.ShowDialog(this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var taskName = GetTaskName();
            var toDoTask = (from task in ToDoApp.ActualTasks
                            where task.Name == taskName
                            select task).First();
            ToDoApp.Delete(toDoTask);
            RefreshUI();
        }

        private void checkDeadline()
        {
            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                var deadline = (DateTime)mainDataGridView.Rows[i].Cells[2].Value;
                var status = (State)mainDataGridView.Rows[i].Cells[1].Value;
                if (deadline < DateTime.Now)
                {
                    mainDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    if (status == State.Done)
                    {
                        mainDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
            RefreshUI();
        }
    }
}
