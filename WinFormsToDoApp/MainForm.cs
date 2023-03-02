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
    public partial class MainForm : Form
    {
        List<Test> testList = new List<Test>();
        public MainForm()
        {
            InitializeComponent();

            testList.Add(new Test() { Cislo = 5, Jmeno = "asd" });
            testList.Add(new Test() { Cislo = 8, Jmeno = "eqweqw" });
            mainDataGridView.DataSource = testList;

            login();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new();
            detailForm.ShowDialog(this);
            detailForm.Dispose();

        }
    }
}
