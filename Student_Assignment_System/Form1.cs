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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminDash = new AdministratorDashboard();
            adminDash.FormClosed += (s, args) => this.Close();
            adminDash.Show();
        }

        private void btnLecturerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LD = new LecturerDashboard();
            LD.FormClosed += (s, args) => this.Close();
            LD.Show();
        }




    }
}
