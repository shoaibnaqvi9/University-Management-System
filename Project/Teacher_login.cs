using BusinessLogicLayer;
using Project;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Teacher_login : Form
    {
        public Teacher_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}