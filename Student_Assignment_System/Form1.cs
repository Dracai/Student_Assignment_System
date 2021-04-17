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

namespace Student_Assignment_System
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        List<Lecturer> lecturerList = new List<Lecturer>();
        List<Administrator> administratorList = new List<Administrator>();

        public Form1()
        {
            InitializeComponent();
            txtUserPassword.PasswordChar = '*';
            
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {/*
            this.Hide();
            var adminDash = new AdministratorDashboard();
            adminDash.FormClosed += (s, args) => this.Close();
            adminDash.Show();*/
        }

        private void btnLecturerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LD = new LecturerDashboard(studentList);
            LD.FormClosed += (s, args) => this.Close();
            LD.Show();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var studentDashboard = new StudentDashboard();
            studentDashboard.Closed += (s, args) => this.Close();
            studentDashboard.Show();
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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool checklogin = false;
            if (ValidateLogin())
            {
                ReadFile(ref studentList, "StudentFiles.dat");
                foreach (Student st in studentList)
                {
                    if (st.StudentID == txtUserID.Text.ToUpper())
                    {
                        if (st.StudentPassword == txtUserPassword.Text)
                        {
                            //Open Student Dashboard
                            this.Hide();
                            var studentDashboard = new StudentDashboard();
                            studentDashboard.Closed += (s, args) => this.Close();
                            studentDashboard.Show();
                            checklogin = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                            break;
                        }
                    }

                }
                ReadFile(ref lecturerList, "LecturerFiles.dat");
                foreach (Lecturer l in lecturerList)
                {
                    if (l.LecturerID == txtUserID.Text.ToUpper())
                    {
                        if (l.LecturerPassword == txtUserPassword.Text)
                        {
                            //Open Lecturer Dashboard
                            this.Hide();
                            var LD = new LecturerDashboard(studentList, l);
                            LD.FormClosed += (s, args) => this.Close();
                            LD.Show();
                            checklogin = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                            break;
                        }
                    }

                }
                ReadFile(ref administratorList, "AdminFile.dat");
                foreach (Administrator a in administratorList)
                {
                    if (a.AdminID == txtUserID.Text.ToUpper())
                    {
                        if (a.AdminPassword == txtUserPassword.Text)
                        {
                            //Open Administrator Password
                            this.Hide();
                            var adminDash = new AdministratorDashboard(a);
                            adminDash.FormClosed += (s, args) => this.Close();
                            adminDash.Show();
                            checklogin = true;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                            break;
                        }
                    }

                }
                if(checklogin==false)
                {
                    MessageBox.Show("No user with that id exists");
                }
            }
        }

        public bool ValidateLogin()
        {
            if(txtUserID.Text == "" || txtUserPassword.Text == "")
            {
                MessageBoxButtons mbb = MessageBoxButtons.OK;
                MessageBox.Show("Please ensure both input fields are not empty", "Invalid Login Attempt",mbb);
                return false;
            }

            return true;
        }


    }






}
