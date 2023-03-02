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
using ToDoAppLib.Iterface;

namespace WinFormsToDoApp
{
    public partial class DetailForm : Form
    {
        MainForm mainForm;
        ToDoTask toDoTask;
        public bool Insert { get; set; } = false;
        public DetailForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            init();
        }

        internal void Clean()
        {
            taskNameTextBox.Text = "";
            priorityCombobox.SelectedItem = Priority.Normal;
            descriptionRichTextBox1.Text = "";
            deadlineDateTimePicker.Value = DateTime.Now;
            deadlineTimeDateTimePicker.Value = DateTime.Now;
            stateComboBox.SelectedItem = State.InProgress;
        }

        private void init()
        {
            priorityCombobox.DataSource = Enum.GetValues(typeof(Priority));
            stateComboBox.DataSource = Enum.GetValues(typeof(State));

            if (Insert != true)
            {
                var taskName = mainForm.GetTaskName();
                toDoTask = (from task in mainForm.ToDoApp.ActualTasks
                            where task.Name == taskName
                            select task).First();

                taskNameTextBox.Text = toDoTask.Name;
                priorityCombobox.SelectedItem = toDoTask.Priority;
                descriptionRichTextBox1.Text = toDoTask.Description;
                deadlineDateTimePicker.Value = (DateTime)toDoTask.Deadline;
                deadlineTimeDateTimePicker.Value = (DateTime)toDoTask.Deadline;
                stateComboBox.SelectedItem = toDoTask.State;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Insert != true)
                mainForm.ToDoApp.Delete(toDoTask);

            toDoTask.Name = taskNameTextBox.Text;
            toDoTask.Priority = (Priority)priorityCombobox.SelectedItem;
            toDoTask.Description = descriptionRichTextBox1.Text;
            toDoTask.Deadline = new DateTime(deadlineDateTimePicker.Value.Year, deadlineDateTimePicker.Value.Month, deadlineDateTimePicker.Value.Day, deadlineTimeDateTimePicker.Value.Hour, deadlineTimeDateTimePicker.Value.Minute, deadlineTimeDateTimePicker.Value.Second);
            toDoTask.State = (State)stateComboBox.SelectedItem;

            mainForm.ToDoApp.Insert(toDoTask);
            mainForm.RefreshUI();
            Close();
        }
    }
}
