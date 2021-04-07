using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//AssignmentList.Add(new Assignment("A001", "Student Application System", Convert.ToDateTime("01/03/2021"), Convert.ToDateTime("05/05/2021"), "SD2A", "Applications Development", "L001", "Group Project For Windows Forms Driven Desktop Application"));
//AssignmentList.Add(new Assignment("A002", "Database Driven Web Application", Convert.ToDateTime("21/01/2021"), Convert.ToDateTime("05/05/2021"), "SD2A", "Data Driven Systems", "L002", "Plan, Develop, Implement and Test a Fully Functional Web Application Driven by PHP"));

namespace Student_Assignment_System
{
    public partial class StudentDashboard : Form
    {
        List<Assignment> AssignmentList = new List<Assignment>();
        List<Assignment> studentAssignments = new List<Assignment>();
        List<string> sCA = new List<string>();

        public StudentDashboard()
        {
            InitializeComponent();
            Student s1 = new Student("Jakub Pawluczuk", Convert.ToDateTime("05/05/2001").Date, "15 Inis Irga", "3571228N", "K00251917", "Password1",
                "Software Development", "SD2A", Convert.ToDateTime("01/09/2019").Date, sCA);

            ReadFile<Assignment>(ref AssignmentList, "AssignmentsFile.dat");
            StudentsAssignments(AssignmentList, studentAssignments, s1);
            setupAssignments();
            startUp(s1);
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

        private static void StudentsAssignments(List<Assignment> AssignmentList, List<Assignment> studentAssignments, Student s1)
        {
            foreach(Assignment a in AssignmentList)
            {
                if(a.ClassGroup == s1.ClassGroup)
                {
                    studentAssignments.Add(a);
                }
            }
        }

        private void setupAssignments()
        {
            foreach(Assignment a in studentAssignments)
            {
                lvStudentAssignments.Items.Add(new ListViewItem(new string[]
                {
                    a.AssignmentID,
                    a.Module,
                    a.Name,
                    a.LecturerID
                }));
            }
        }

        private void StudentFormIndexChange(object sender, EventArgs e)
        {
            if (tcStudentDash.SelectedTab.Text == "Dashboard")
            {
                
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

        private void startUp(Student s1)
        {
            lblStudentWelcome.Text = "Welcome, " + s1.Name;
            txtStudentCourse.Text = s1.Course;
            txtStudentClassgroup.Text = s1.ClassGroup;
            txtStudentAssignmentNum.Text = studentAssignments.Count.ToString();
        }

        private void SelectedAssignment(object sender, EventArgs e)
        {
            foreach(ListViewItem x in lvStudentAssignments.SelectedItems)
            {
                foreach(Assignment a in AssignmentList)
                {
                    if(a.AssignmentID == x.SubItems[0].Text)
                    {
                        this.txtAModuleID.Text = a.Module;
                        this.txtAName.Text = a.Name;
                        this.txtADateDue.Text = a.DateDue.Date.ToString();
                        this.txtALecturer.Text = a.LecturerID;
                        this.txtADescription.Text = a.Description;
                    }
                }
            }
        }
    }
}
