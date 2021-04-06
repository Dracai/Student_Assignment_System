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
        public AdminDetails()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                Administrator admin = new Administrator(txtAdminID.Text, txtAdminPassword.Text, Convert.ToInt32(txtAdminPhoneNumber.Text), txtAdminDateOfHire.Text, txtAdminName.Text, txtAdminDOB.Text, txtAdminAddress.Text, txtAdminPPSN.Text);
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
