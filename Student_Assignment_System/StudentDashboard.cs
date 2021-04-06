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
    public partial class StudentDashboard : Form
    {
        Student s1 = new Student("Jakub Pawluczuk", Convert.ToDateTime("05/05/2001"), "15 Inis Irga", "3571228N", "K00251917", "Password1",
            "Software Development", "SD2A", Convert.ToDateTime("01/09/2019"));

        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentLogout(object sender, EventArgs e)
        {
            if (tcStudentDash.SelectedTab.Text == "Dashboard")
            {
                txtStudentCourse.Text = s1.Course;
                txtStudentClassgroup.Text = s1.ClassGroup;
            }
            else if (tcStudentDash.SelectedTab.Text == "Assignments")
            {

            }
            else if (tcStudentDash.SelectedTab.Text == "Logout")
            {
                this.Hide();
                var Login = new Form1();
                Login.Closed += (s, args) => this.Close();
                Login.Show();
            }
        }
    }
}
