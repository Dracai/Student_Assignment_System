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


namespace Student_Assignment_System
{
    public partial class StudentDashboard : Form
    {
        Student student;
        List<Assignment> AssignmentList = new List<Assignment>();
        List<Assignment> studentAssignments = new List<Assignment>();
        List<Student> studentList = new List<Student>();


        public StudentDashboard(Student st, List<Student> studList)
        {
            InitializeComponent();
            student = st;
            List<Student> studentList = studList;
            Debug.WriteLine(studentList.Count);
            ReadFile<Assignment>(ref AssignmentList, "AssignmentFiles.dat");
            StudentsAssignments(AssignmentList, studentAssignments, student);
            setupAssignments();
            startUp(student);
        }

        private void setupDeadlines()
        {
            ListViewItem item;
                foreach (Assignment a in studentAssignments)
                {
                    string[] arr = new string[2];
                    arr[0] = a.Name;
                    arr[1] = a.DateDue.ToShortDateString();
                    item = new ListViewItem(arr);
                    lvDeadlines.Items.Add(item);
                }
            
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

        public static void WriteFile<T>(List<T> list, string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            FileStream stream;

            if (fileInfo.Exists)
            {
                stream = new FileStream(file, FileMode.Truncate, FileAccess.Write);
                Console.WriteLine("found file " + fileInfo.FullName);
            }
            else
            {
                stream = new FileStream(file, FileMode.Create, FileAccess.Write);
                Console.WriteLine("created file" + fileInfo.FullName);
            }

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, list);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }

            stream.Close();
            Console.WriteLine("Data written to file");
        }

        private static void StudentsAssignments(List<Assignment> AssignmentList, List<Assignment> studentAssignments, Student student)
        {
            foreach(Assignment a in AssignmentList)
            {
                if(a.ClassGroup == student.ClassGroup && !student.CompletedAssignments.Contains(a.AssignmentID))
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
                this.txtStudentCourse.Clear();
                this.txtStudentClassgroup.Clear();
                this.txtStudentAssignmentNum.Clear();
                this.lvDeadlines.Items.Clear();
                this.studentAssignments.Clear();

                StudentsAssignments(AssignmentList, studentAssignments, student);
                startUp(student);
            }
            else if (tcStudentDash.SelectedTab.Text == "Assignments")
            {
                ReadFile(ref studentList, "StudentFiles.dat");
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
            setupDeadlines();
        }

        private void lvStudentAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem x in lvStudentAssignments.SelectedItems)
            {
                foreach(Assignment a in AssignmentList)
                {
                    if(a.AssignmentID == x.SubItems[0].Text)
                    {
                        this.txtSAModuleID.Text = a.Module;
                        this.txtSAName.Text = a.Name;
                        this.txtSADateDue.Text = a.DateDue.ToString();
                        this.txtSALecturer.Text = a.LecturerID;
                        this.txtSADesciption.Text = a.Description;
                    }
                }
            }
        }

        private void btnAComplete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem x in lvStudentAssignments.SelectedItems)
            {
                student.CompletedAssignments.Add(x.SubItems[0].Text);
                Debug.WriteLine(student.CompletedAssignments.Count);
                AssignmentList.RemoveAt(x.Index);
                lvStudentAssignments.Items.RemoveAt(x.Index);
            }

            this.txtSAModuleID.Clear();
            this.txtSAName.Clear();
            this.txtSADateDue.Clear();
            this.txtSALecturer.Clear();
            this.txtSADesciption.Clear();

            WriteFile<Student>(studentList, "StudentFiles.dat");
        }
    }
}
