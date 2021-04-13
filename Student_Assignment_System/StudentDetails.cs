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

namespace Student_Assignment_System
{
    public partial class StudentDetails : Form
    {
        public StudentDetails(string detailsHeading, Student selectedStudent = null)
        {
            InitializeComponent();
            if(!(selectedStudent == null))
            {
                txtStudentID.Text = selectedStudent.StudentID;
                txtStudentName.Text = selectedStudent.Name;
                dtpStudentDOB.Value = selectedStudent.DateOfBirth;
                txtStudentAddress.Text = selectedStudent.Address;
                txtStudentPPSN.Text = selectedStudent.PPSNumber;
                txtStudentPassword.Text = selectedStudent.StudentPassword;
                txtStudentClassGroups.Text = selectedStudent.ClassGroup;
                txtStudentCourse.Text = selectedStudent.Course;
                dtpStudentDateEnrolled.Value = selectedStudent.DateEnrolled;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                List<string> sCA = new List<string>();
                Student stud = new Student(txtStudentName.Text, dtpStudentDOB.Value, txtStudentAddress.Text, txtStudentPPSN.Text, txtStudentID.Text, txtStudentPassword.Text, txtStudentCourse.Text, txtStudentClassGroups.Text, dtpStudentDateEnrolled.Value, sCA);
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
