using BusinessLogicLayer;
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
            try
            {
                int sid = int.Parse(txtID.Text);
                string spassword = txtPassword.Text;
                BLL b = new BLL();
                bool loginSuccessful = b.SelectTeacher(sid, spassword);
                if (loginSuccessful)
                {
                    MessageBox.Show("LoggedIn Successfully");
                    this.Hide();
                    Form f = new Dashboard();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Teacher ID or Password");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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