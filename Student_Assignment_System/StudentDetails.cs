using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Student_Assignment_System
{
    public partial class StudentDetails : Form
    {
        List<Assignment> assignmentList = new List<Assignment>();
        List<ClassGroup> ClassGroups = new List<ClassGroup>();
        public StudentDetails(string detailsHeading, Student selectedStudent = null)
        {
            InitializeComponent();
            txtStudentID.ReadOnly = true;
            ReadFile<Assignment>(ref assignmentList, "AssignmentFiles.dat");
            ReadFile<ClassGroup>(ref ClassGroups, "ClassGroupFile.dat");
            foreach (ClassGroup cg in ClassGroups)
            {
                clbClassGroups.Items.Add(cg.ClassGroupName);
            }
            if (!(selectedStudent == null))
            {
                
                txtStudentID.Text = selectedStudent.StudentID;
                txtStudentName.Text = selectedStudent.Name;
                dtpStudentDOB.Value = selectedStudent.DateOfBirth;
                txtStudentAddress.Text = selectedStudent.Address;
                txtStudentPPSN.Text = selectedStudent.PPSNumber;
                txtStudentPassword.Text = selectedStudent.StudentPassword;
                clbClassGroups.SetItemChecked(clbClassGroups.Items.IndexOf(selectedStudent.ClassGroup), true);
                txtStudentCourse.Text = selectedStudent.Course;
                dtpStudentDateEnrolled.Value = selectedStudent.DateEnrolled;
                foreach(Assignment a in assignmentList)
                {
                    if (a.ClassGroup == selectedStudent.ClassGroup) 
                        clbStudentCompletedAssignments.Items.Add(a.AssignmentID);
                }
                foreach (Assignment a in assignmentList)
                {
                    if (selectedStudent.CompletedAssignments.Contains(a.AssignmentID))
                    {
                        clbStudentCompletedAssignments.SetItemChecked(clbStudentCompletedAssignments.Items.IndexOf(a.AssignmentID), true);
                    }
                }

            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                Random random = new Random();
                string kNumber = $"K00{random.Next(100000,999999)}";
                List<string> sCA = new List<string>();
                Student stud = new Student(txtStudentName.Text, dtpStudentDOB.Value, txtStudentAddress.Text, txtStudentPPSN.Text, kNumber, txtStudentPassword.Text, txtStudentCourse.Text, clbClassGroups.SelectedItem.ToString(), dtpStudentDateEnrolled.Value, sCA);
                this.Tag = stud;
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
            if (!Regex.IsMatch(txtStudentName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name has to contain alphabetic characters only");
                return false;
            }
            else if(String.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Name text box cannot be empty");
                return false;
            }
            else if(dtpStudentDOB.Value >= DateTime.Today)
            {
                MessageBox.Show("Select a valid date of birth");
                return false;
            }
            else if (String.IsNullOrEmpty(txtStudentAddress.Text))
            {
                MessageBox.Show("Address text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtStudentPPSN.Text))
            {
                MessageBox.Show("PPS number  text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtStudentPassword.Text))
            {
                MessageBox.Show("Password text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtStudentPassword.Text))
            {
                MessageBox.Show("Password text box cannot be empty");
                return false;
            }
            else if(clbClassGroups.SelectedItems.Count > 1)
            {
                MessageBox.Show("Select only one class group");
            }
            else if (clbClassGroups.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a class group");
            }
            else if (String.IsNullOrEmpty(txtStudentCourse.Text))
            {
                MessageBox.Show("Course text box cannot be empty");
                return false;
            }
            else if (dtpStudentDateEnrolled.Value >= dtpStudentDOB.Value)
            {
                MessageBox.Show("Pick a valid date enrolled");
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
    }
}
