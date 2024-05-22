using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnrgdoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Student_registration();
            f.Show();
        }

        private void btnlgdoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Teacher_login();
            f.Show();
        }

        private void btnrgpat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Teacher_registration();
            f.Show();
        }

        private void btnlgpat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Student_login();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}