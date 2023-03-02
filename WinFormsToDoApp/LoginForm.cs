using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsToDoApp
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*Login login = new Login();

           if (login.login(userTextBox.Text, passwordTextBox.Text))
           {
               mainForm.UserName = userTextBox.Text;
               Close();
           }*/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
