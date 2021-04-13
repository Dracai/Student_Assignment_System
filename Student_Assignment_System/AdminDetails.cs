using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assignment_System
{
    public partial class AdminDetails : Form
    {
        public AdminDetails(string detailsHeading, Administrator selectedAdmin = null)
        {
            InitializeComponent();
            if(!(selectedAdmin == null))
            {
                txtAdminID.Text = selectedAdmin.AdminID;
                txtAdminName.Text = selectedAdmin.Name;
                txtAdminDOB.Text = selectedAdmin.DateOfBirth.ToShortDateString();
                txtAdminAddress.Text = selectedAdmin.Address;
                txtAdminPPSN.Text = selectedAdmin.PPSNumber;
                txtAdminPassword.Text = selectedAdmin.AdminPassword;
                txtAdminPhoneNumber.Text = selectedAdmin.PhoneNumber;
                txtAdminDateOfHire.Text = selectedAdmin.DateOfHire.ToShortDateString();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                Administrator admin = new Administrator(txtAdminID.Text, txtAdminPassword.Text, txtAdminPhoneNumber.Text, Convert.ToDateTime(txtAdminDateOfHire.Text), txtAdminName.Text, Convert.ToDateTime(txtAdminDOB.Text), txtAdminAddress.Text, txtAdminPPSN.Text);
                this.Tag = admin;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //Validate your shit son

            }

        }

        public bool validateInput()
        {
            return true;
        }

        private void txtAdminDateOfHire_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminPPSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdminDateOfHire_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminPPSN_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {

        }

        private void lblAdminID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
