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
            try
            {
                int sid = int.Parse(lblID.Text);
                int spassword = int.Parse(lblPassword.Text);
                BLL b = new BLL();
                bool loginSuccessful = b.SelectStudent(sid, spassword);
                if (loginSuccessful)
                {
                    MessageBox.Show("LoggedIn Successfully");
                    this.Hide();
                    Form f = new Dashboard();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Student ID");
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
