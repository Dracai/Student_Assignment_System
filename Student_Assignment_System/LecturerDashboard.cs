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
    public partial class LecturerDashboard : Form
    {
        List<Student> StudentList = new List<Student>();
        List<Assignment> AssignmentList = new List<Assignment>();
        List<ClassGroup> ClassGroupList = new List<ClassGroup>();

        public LecturerDashboard(List<Student> stulist)
        {
            InitializeComponent();
            List<Student> StudentList = stulist;
            ReadFiles();
        }

        private void LecLogout(object sender, EventArgs e)
        {
            if (tcDash.SelectedTab.Text == "Logout")
            {
                this.Hide();
                var Login = new Form1();
                Login.Closed += (s, args) => this.Close();
                Login.Show();
            }
        }

        private void ReadFiles()
        {
            List<Assignment> temp1 = new List<Assignment>();

            FileInfo AfInfo = new FileInfo("AssignmentFiles.dat");
            FileStream AssignmentFile;

            if (AfInfo.Exists)
            {
                AssignmentFile = new FileStream("AssignmentFiles.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bformatter = new BinaryFormatter();
                try
                {
                    temp1 = bformatter.Deserialize(AssignmentFile) as List<Assignment>;
                    AssignmentList = temp1;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e} Exception caught.");
                }
                AssignmentFile.Close();
            }
            else
            {
                MessageBox.Show("ERROR CANT FIND FILE " + AfInfo.FullName);
            }


            List<ClassGroup> temp2 = new List<ClassGroup>();
            FileInfo CGfInfo = new FileInfo("ClassGroupFile.dat");
            FileStream ClassFile;

            if (CGfInfo.Exists)
            {
                ClassFile = new FileStream("ClassList.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bformatter = new BinaryFormatter();
                try
                {
                    temp2 = bformatter.Deserialize(ClassFile) as List<ClassGroup>;
                    ClassGroupList = temp2;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e} Exception caught.");
                }
                ClassFile.Close();
            }
            else
            {
                MessageBox.Show("ERROR CANT FIND FILE " + CGfInfo.FullName);
            }
        }

        private void SaveFiles()
        {
            FileInfo AfInfo = new FileInfo("AssignmentFiles.dat");
            FileStream AssignmentFile;

            if (AfInfo.Exists)
            {
                AssignmentFile = new FileStream("AssignmentFiles.dat", FileMode.Create, FileAccess.Write);
            }
            else
            {
                AssignmentFile = new FileStream("AssignmentFiles.dat", FileMode.Create, FileAccess.Write);
            }

            BinaryFormatter bformatter = new BinaryFormatter();

            try
            {
                bformatter.Serialize(AssignmentFile, AssignmentList);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            AssignmentFile.Close();

            
            FileInfo CGfInfo = new FileInfo("ClassGroupFile.dat");
            FileStream ClassFile;

            if (CGfInfo.Exists)
            {
                ClassFile = new FileStream("ClassGroupFile.dat", FileMode.Create, FileAccess.Write);
            }
            else
            {
                ClassFile = new FileStream("ClassGroupFile.dat", FileMode.Create, FileAccess.Write);
            }

            BinaryFormatter rbformatter = new BinaryFormatter();

            try
            {
                rbformatter.Serialize(ClassFile, ClassGroupList);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            ClassFile.Close();
        }

        private void btnAssignmentsGo_Click(object sender, EventArgs e)
        {
            tcDash.SelectedTab = tcDash.TabPages[1];
        }

        private void btnClassGroupsGo_Click(object sender, EventArgs e)
        {
            tcDash.SelectedTab = tcDash.TabPages[2];
        }
    }
}
