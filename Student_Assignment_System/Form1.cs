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
    }
}
