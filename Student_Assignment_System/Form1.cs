﻿using System;
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
            txtPassword.PasswordChar = '*';
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
<<<<<<< Updated upstream
=======

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                ReadFile(ref studentList, "StudentFiles.dat");
                foreach (Student st in studentList)
                {
                    if (st.StudentID == txtID.Text)
                    {
                        if (st.StudentPassword == txtPassword.Text)
                        {
                            //Open Student Dashboard
                            this.Hide();
                            var studentDashboard = new StudentDashboard();
                            studentDashboard.Closed += (s, args) => this.Close();
                            studentDashboard.Show();

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
                    if (l.LecturerID == txtID.Text)
                    {
                        if (l.LecturerPassword == txtPassword.Text)
                        {
                            //Open Lecturer Dashboard
                            this.Hide();
                            var LD = new LecturerDashboard(studentList);
                            LD.FormClosed += (s, args) => this.Close();
                            LD.Show();

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
                    if (a.AdminID == txtID.Text)
                    {
                        if (a.AdminPassword == txtPassword.Text)
                        {
                            //Open Administrator Password
                            this.Hide();
                            var adminDash = new AdministratorDashboard();
                            adminDash.FormClosed += (s, args) => this.Close();
                            adminDash.Show();

                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                            break;
                        }
                    }

                }
            }
        }

        public bool ValidateLogin()
        {
            if(txtID.Text == "" || txtPassword.Text == "")
            {
                MessageBoxButtons mbb = MessageBoxButtons.OK;
                MessageBox.Show("Please ensure both input fields are not empty", "Invalid Login Attempt",mbb);
                return false;
            }

            return true ;
        }

>>>>>>> Stashed changes
    }
}
