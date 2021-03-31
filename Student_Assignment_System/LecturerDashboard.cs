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
        List<Lecturer> LecturerList = new List<Lecturer>();
        List<ClassGroup> ClassGroupList = new List<ClassGroup>();

        public LecturerDashboard()
        {
            InitializeComponent();
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
            List<Lecturer> temp1 = new List<Lecturer>();

            FileInfo LfInfo = new FileInfo("LecturerFiles.dat");
            FileStream LecturerFile;

            if (LfInfo.Exists)
            {
                LecturerFile = new FileStream("LecturerFiles.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bformatter = new BinaryFormatter();
                try
                {
                    temp1 = bformatter.Deserialize(LecturerFile) as List<Lecturer>;
                    LecturerList = temp1;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e} Exception caught.");
                }
                LecturerFile.Close();
            }
            else
            {
                MessageBox.Show("ERROR CANT FIND FILE " + LfInfo.FullName);
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
            FileInfo LfInfo = new FileInfo("LecturerFiles.dat");
            FileStream LecturerFile;

            if (LfInfo.Exists)
            {
                LecturerFile = new FileStream("LecturerFiles.dat", FileMode.Create, FileAccess.Write);
                //Console.WriteLine("found file " + RecipefInfo.FullName);
            }
            else
            {
                LecturerFile = new FileStream("LecturerFiles.dat", FileMode.Create, FileAccess.Write);
                //Console.WriteLine("created file " + RecipefInfo.FullName);
            }

            BinaryFormatter bformatter = new BinaryFormatter();

            try
            {
                bformatter.Serialize(LecturerFile, LecturerList);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            LecturerFile.Close();

            
            FileInfo CGfInfo = new FileInfo("ClassGroupFile.dat");
            FileStream ClassFile;

            if (CGfInfo.Exists)
            {
                ClassFile = new FileStream("ClassGroupFile.dat", FileMode.Create, FileAccess.Write);
                //Console.WriteLine("found file " + AllergenfInfo.FullName);
            }
            else
            {
                ClassFile = new FileStream("ClassGroupFile.dat", FileMode.Create, FileAccess.Write);
                //Console.WriteLine("created file " + AllergenfInfo.FullName);
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



    }
}
