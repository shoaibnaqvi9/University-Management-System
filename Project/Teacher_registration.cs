using System;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace Project
{
    public partial class Teacher_registration : Form
    {
        public Teacher_registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Dashboard();
            f.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int tid = int.Parse(txtTeacherid.Text);
                string tname = txtTeachername.Text;
                string tgender = txtPatientgender.Text;
                string tCNIC = txtCNIC.Text;
                string tcontact = txtcontact.Text;
                
                if (!System.Text.RegularExpressions.Regex.IsMatch(tCNIC, @"^\d{13}$"))
                {
                    throw new FormatException("Invalid CNIC format. CNIC must be 13 digits long and contain only numbers.");
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(tcontact, @"^\d{12}$"))
                {
                    throw new FormatException("Invalid contact number format. Contact number must be 12 digits long and contain only numbers.");
                }
                BLL b = new BLL();
                b.RegisterTeacher(tid, tname, tgender, tCNIC, tcontact);
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

        private void lblTeachername_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_registration_Load(object sender, EventArgs e)
        {

        }

        private void lblTR_Click(object sender, EventArgs e)
        {

        }
    }
}