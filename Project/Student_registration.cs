using BusinessLogicLayer;
using System;
using System.Windows.Forms;
namespace Project
{
    public partial class Student_registration : Form
    {
        public Student_registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int sid = int.Parse(txtStudentid.Text);
                string sname = txtStudentname.Text;
                string scontact = txtcontact.Text;
                string saddress = txtaddress.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(scontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                BLL b = new BLL();
                b.RegisterStudent(sid, sname, scontact, saddress);
                MessageBox.Show("<----Registered---->");
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

        private void doctor_registration_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }
    }
}
