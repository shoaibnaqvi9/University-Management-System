using System;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace Project
{
    public partial class Student_login : Form
    {
        public Student_login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void patient_login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
