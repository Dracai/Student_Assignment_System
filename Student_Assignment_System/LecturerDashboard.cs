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
        //Temp User
        
        Lecturer user;


        List<Module> ModuleList = new List<Module>();
        List<Student> StudentList = new List<Student>();
        List<Assignment> AssignmentList = new List<Assignment>();
        List<ClassGroup> ClassGroupList = new List<ClassGroup>();

        public LecturerDashboard(List<Student> stulist)
        {
            InitializeComponent();
            List<Student> StudentList = stulist;
            ReadFiles();
            SetUpData();
            UpdateListViews();
            //SaveFiles();
            List<string> mod = new List<string>();
            mod.Add("M002");
            user = new Lecturer("Guinane Man", Convert.ToDateTime("23/02/1293"), "Hobbiton", "PHHHHHP", "L002", "PASSWORD2", mod, Convert.ToDateTime("23/03/0987"));


        }

        //TestDataFunction
        public void SetUpData()
        {
            List<string> softdev = new List<string>();
            softdev.Add("SD2A");
            softdev.Add("SD2B");
            ModuleList.Add(new Module("M001", "Applications Development", 5,softdev));
            ModuleList.Add(new Module("M002", "Data Driven Systems", 5,softdev));
            AssignmentList.Add(new Assignment("A001","Student Application System", Convert.ToDateTime("01/03/2021"), Convert.ToDateTime("05/05/2021"), "SD2A","Applications Development","L001","Group Project For Windows Forms Driven Desktop Application"));
            AssignmentList.Add(new Assignment("A002", "Database Driven Web Application", Convert.ToDateTime("21/01/2021"), Convert.ToDateTime("05/05/2021"), "SD2A", "Data Driven Systems", "L002","Plan, Develop, Implement and Test a Fully Functional Web Application Driven by PHP"));
            ClassGroupList.Add(new ClassGroup("SD2A", "Software Development", "2", 18));
            ClassGroupList.Add(new ClassGroup("SD2B", "Software Development", "2", 19));
            StudentList.Add(new Student("Conor Moroney", Convert.ToDateTime("18/04/2001"), "Inchadrinagh", "1001000A", "K00251153", "PASSWORD1", "Software Development", "SD2A", Convert.ToDateTime("06/09/2020")));
            StudentList.Add(new Student("Ethan Caffrey", Convert.ToDateTime("11/09/2017"), "Six Mile Bridge", "1001001A", "K00251154", "PASSWORD1", "Software Development", "SD2A", Convert.ToDateTime("06/09/2020")));
            StudentList.Add(new Student("Jakub Pawluczuk", Convert.ToDateTime("12/11/2001"), "Six Mile Bridge", "1001011A", "K00251155", "PASSWORD1", "Software Development", "SD2A", Convert.ToDateTime("06/09/2020")));
            StudentList.Add(new Student("Callum Moloney", Convert.ToDateTime("18/04/2001"), "Ennis", "1001111A", "K00251156", "PASSWORD1", "Software Development", "SD2B", Convert.ToDateTime("06/09/2020")));
            StudentList.Add(new Student("Cian Godfrey", Convert.ToDateTime("11/09/2000"), "Shannon", "1011111A", "K00251157", "PASSWORD1", "Software Development", "SD2B", Convert.ToDateTime("06/09/2020")));
            StudentList.Add(new Student("Jacob Paulson", Convert.ToDateTime("12/04/2001"), "Dingle", "1111111A", "K00251158", "PASSWORD1", "Software Development", "SD2B", Convert.ToDateTime("06/09/2020")));
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
            ReadFile<Module>(ref ModuleList, "ModuleFiles.dat");
            ReadFile<Assignment>(ref AssignmentList, "AssignmentFiles.dat");
            ReadFile<ClassGroup>(ref ClassGroupList, "ClassGroupFiles.dat");
        }

        private void SaveFiles()
        {
            //WriteFile<Assignment>(AssignmentList, "AssignmentFiles.dat");
            WriteFile<ClassGroup>(ClassGroupList, "ClassGroupFile.dat");
        }

        public void UpdateListViews()
        {
            ListViewItem item;
            foreach(ClassGroup cg in ClassGroupList)
            {
                item = new ListViewItem(cg.ClassGroupName);
                item.SubItems.Add(cg.Course);
                item.SubItems.Add(cg.YearOfStudy);
                item.SubItems.Add(cg.NumberOfStudents.ToString());
                lvAssignmentsCG.Items.Add(item);
            }

            foreach (ClassGroup cg in ClassGroupList)
            {
                item = new ListViewItem(cg.ClassGroupName);
                item.SubItems.Add(cg.Course);
                item.SubItems.Add(cg.YearOfStudy);
                item.SubItems.Add(cg.NumberOfStudents.ToString());
                lvClassGroupsCG.Items.Add(item);
            }

            foreach(Assignment a in AssignmentList)
            {
                item = new ListViewItem(a.AssignmentID);
                item.SubItems.Add(a.Name);
                item.SubItems.Add(a.DateDue.ToShortDateString().ToString());
                item.SubItems.Add(a.Module);
                lvAssignmentsAss.Items.Add(item);
            }
            

        }

        private void btnAssignmentsGo_Click(object sender, EventArgs e)
        {
            tcDash.SelectedTab = tcDash.TabPages[1];
        }

        private void btnClassGroupsGo_Click(object sender, EventArgs e)
        {
            tcDash.SelectedTab = tcDash.TabPages[2];
        }

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            /*
            var AD = new AssignmentDetails(ref user);
            AD.FormClosed += (s, args) => this.Close();
            AD.Show();
            */
            
            Form assignmentDetails = new AssignmentDetails(ref user,ModuleList,ClassGroupList);
            DialogResult completeBtn = assignmentDetails.ShowDialog();
            if (completeBtn == DialogResult.OK)
            {
                Assignment newassignment = (Assignment)assignmentDetails.Tag;
                AssignmentList.Add(newassignment);
            }
            lvAssignmentsAss.Items.Clear();
            lvAssignmentsCG.Items.Clear();
            lvClassGroupsCG.Items.Clear();
            UpdateListViews();
        }
    }
}
