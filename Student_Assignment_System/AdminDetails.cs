using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assignment_System
{
    public partial class AdminDetails : Form
    {
        public AdminDetails(string detailsHeading, Administrator selectedAdmin = null)
        {
            txtAdminID.ReadOnly = true;
            InitializeComponent();
            if(!(selectedAdmin == null))
            {
                txtAdminID.Text = selectedAdmin.AdminID;
                txtAdminName.Text = selectedAdmin.Name;
                dtpAdminDOB.Value = selectedAdmin.DateOfBirth;
                txtAdminAddress.Text = selectedAdmin.Address;
                txtAdminPPSN.Text = selectedAdmin.PPSNumber;
                txtAdminPassword.Text = selectedAdmin.AdminPassword;
                txtAdminPhoneNumber.Text = selectedAdmin.PhoneNumber;
                dtpAdminDateOfHire.Value = selectedAdmin.DateOfHire;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                List<Administrator> adminlist = new List<Administrator>();
                ReadFile<Administrator>(ref adminlist, "AdminFile.dat");
                List<string> adminIDList = adminlist.Select(_ => _.AdminID).ToList();
                Random random = new Random();
                string adminID= $"A{random.Next(100, 999)}";
                while (adminIDList.Contains(adminID))
                {
                    adminID = $"L{random.Next(100, 999)}";
                }
                Administrator admin = new Administrator(adminID, txtAdminPassword.Text, txtAdminPhoneNumber.Text, dtpAdminDOB.Value, txtAdminName.Text, dtpAdminDateOfHire.Value, txtAdminAddress.Text, txtAdminPPSN.Text);
                this.Tag = admin;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        public bool validateInput()
        {
            if (!Regex.IsMatch(txtAdminName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name has to contain alphabetic characters only");
                return false;
            }
            else if (String.IsNullOrEmpty(txtAdminName.Text))
            {
                MessageBox.Show("Name text box cannot be empty");
                return false;
            }
            else if (dtpAdminDOB.Value >= DateTime.Today)
            {
                MessageBox.Show("Select a valid date of birth");
                return false;
            }
            else if (String.IsNullOrEmpty(txtAdminAddress.Text))
            {
                MessageBox.Show("Address text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtAdminPPSN.Text))
            {
                MessageBox.Show("PPS number  text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtAdminPassword.Text))
            {
                MessageBox.Show("Password text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtAdminPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number text box cannot be empty");
                return false;
            }
            else if (dtpAdminDateOfHire.Value >= dtpAdminDOB.Value)
            {
                MessageBox.Show("Pick a valid date of hire");
                return false;
            }
            return true;
        }

        public static void ReadFile<T>(ref List<T> list, string file)
        {
            List<T> templist = new List<T>();
            FileInfo fileInfo = new FileInfo(file);
            FileStream stream;

            if (fileInfo.Exists)
            {
                stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    templist = formatter.Deserialize(stream) as List<T>;
                    list = templist;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception caught {e}");
                }
                stream.Close();
            }
            else
            {
                Console.WriteLine($"ERROR CANT FIND FILE " + fileInfo.FullName);
            }
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
