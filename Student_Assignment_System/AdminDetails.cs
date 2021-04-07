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
        public AdminDetails(string formHeading, Administrator selectedAdmin = null)
        {
            InitializeComponent();
            lblDetailsHeading.Text = formHeading;
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
    }
}
