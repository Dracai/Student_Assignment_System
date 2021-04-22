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
    public partial class LecturerDashboard : Form
    {

        Lecturer user = new Lecturer();
        List<Module> ModuleList = new List<Module>();
        List<Student> StudentList = new List<Student>();
        List<Assignment> AssignmentList = new List<Assignment>();
        List<ClassGroup> ClassGroupList = new List<ClassGroup>();

        public LecturerDashboard(List<Student> stulist, Lecturer User = null)
        {
            InitializeComponent();
            List<Student> StudentList = stulist;
            ReadFiles();
            
            List<string> mod = new List<string>();
            mod.Add("M002");
            mod.Add("M001");
            if (User == null)
            {
                User = new Lecturer("Guinane Man", Convert.ToDateTime("23/02/1293"), "Hobbiton", "PHHHHHP", "L002", "PASSWORD2", mod, Convert.ToDateTime("23/03/0987"));   
            }
            user = User;
            lblLectName.Text = user.Name;
            UpdateListViews();
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
                SaveFiles();
                this.Hide();
                var Login = new Form1();
                Login.Closed += (s, args) => this.Close();
                Login.Show();
            }
        }

        private void ReadFiles()
        {
            ReadFile<Module>(ref ModuleList, "ModuleFile.dat");
            ReadFile<Assignment>(ref AssignmentList, "AssignmentFiles.dat");
            ReadFile<ClassGroup>(ref ClassGroupList, "ClassGroupFile.dat");
            ReadFile<Student>(ref StudentList, "StudentFiles.dat");
        }

        private void SaveFiles()
        {
            WriteFile<Assignment>(AssignmentList, "AssignmentFiles.dat");
        }

        public void UpdateListViews()
        {
            List<string> moduleaccess = new List<string>();
            lvAssignmentsAss.Items.Clear();
            lvAssignmentsCG.Items.Clear();
            lvClassGroupsCG.Items.Clear();

            ListViewItem item;
            foreach (ClassGroup cg in ClassGroupList)
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

            foreach(Module m in ModuleList)
            {
                if(user.ModulesToTeach.Contains(m.ModuleCode))
                {
                    moduleaccess.Add(m.ModuleName);
                    Debug.WriteLine(m.ModuleName);
                }
            }

            foreach (Assignment a in AssignmentList)
            {
                if (moduleaccess.Contains(a.Module))
                {
                    item = new ListViewItem(a.AssignmentID);
                    item.SubItems.Add(a.Name);
                    item.SubItems.Add(a.DateDue.ToShortDateString().ToString());
                    item.SubItems.Add(a.Module);
                    lvAssignmentsAss.Items.Add(item);
                }
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
            if (lvAssignmentsCG.SelectedItems.Count > 0)
            {
                Random random = new Random();
                var s = AssignmentList.Select(_ => _.AssignmentID);
                string id = "";
                int timeout = 0;
                
                while (timeout<15)
                {
                    id = $"A{(random.Next(1, 101)).ToString().PadLeft(3, '0')}";
                    if (!s.Contains(id))
                        break;
                    timeout++;
                }
                if (timeout == 15)
                {
                    id = "";
                }
                Form assignmentDetails = new AssignmentDetails(ref user,lvAssignmentsCG.SelectedItems[0].Text,null,id);
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
            else
            {
                MessageBox.Show("Please Select A Class Group", "Error");
            }
        }

        private void btnRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (lvAssignmentsAss.SelectedItems.Count > 0)
            {
                foreach (Assignment a in AssignmentList)
                {
                    if (a.AssignmentID == lvAssignmentsAss.SelectedItems[0].Text)
                    {
                        AssignmentList.Remove(a);
                        UpdateListViews();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select An Assignment", "Error");
            }

        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (lvAssignmentsAss.SelectedItems.Count > 0)
            {
                foreach (Assignment a in AssignmentList)
                {
                    if (a.AssignmentID == lvAssignmentsAss.SelectedItems[0].Text)
                    {
                        MessageBox.Show(a.Description);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select An Assignment", "Error");
            }
        }

        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            DialogResult completeBtn = DialogResult.No;
            Form assignmentDetails;
            if (lvAssignmentsAss.SelectedItems.Count > 0)
            {

                assignmentDetails = new AssignmentDetails(ref user, "", AssignmentList[lvAssignmentsAss.Items.IndexOf(lvAssignmentsAss.SelectedItems[0])]);
                completeBtn = assignmentDetails.ShowDialog();
                if (completeBtn == DialogResult.OK)
                {
                    Assignment newassignment = (Assignment)assignmentDetails.Tag;
                    AssignmentList[lvAssignmentsAss.Items.IndexOf(lvAssignmentsAss.SelectedItems[0])] = newassignment;
                }
                UpdateListViews();

            }
            else
            {
                MessageBox.Show("Please Select An Assignment To Edit", "Error");
            }
        }

        private void btnAssSave_Click(object sender, EventArgs e)
        {
            SaveFiles();
        }

        private void UpdateStudentsLV(object sender, EventArgs e)
        {
            if (lvClassGroupsCG.SelectedItems.Count > 0)
            {
                lvStudents.Items.Clear();
                string cg = ClassGroupList[lvClassGroupsCG.Items.IndexOf(lvClassGroupsCG.SelectedItems[0])].ClassGroupName;
                ListViewItem item;
                foreach (Student s in StudentList)
                {
                    if (cg == s.ClassGroup)
                    {
                        item = new ListViewItem(s.StudentID);
                        item.SubItems.Add(s.Name);
                        lvStudents.Items.Add(item);
                    }
                }
            }
        }

        private void btnViewNextWeek_Click(object sender, EventArgs e)
        {
            if (lvClassGroupsCG.SelectedItems.Count > 0)
            {
                Form up = new UpcomingAssignments(ClassGroupList[lvClassGroupsCG.Items.IndexOf(lvClassGroupsCG.SelectedItems[0])].ClassGroupName, "Week");
                up.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Class Group", "Error");
            }

        }

        private void btnViewNextMonth_Click(object sender, EventArgs e)
        {
            if (lvClassGroupsCG.SelectedItems.Count > 0)
            {
                Form up = new UpcomingAssignments(ClassGroupList[lvClassGroupsCG.Items.IndexOf(lvClassGroupsCG.SelectedItems[0])].ClassGroupName, "Month");
                up.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Class Group", "Error");
            }
        }
    }
}
