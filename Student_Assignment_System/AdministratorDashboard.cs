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
    public partial class AdministratorDashboard : Form
    {
        List<Administrator> AdminList = new List<Administrator>();
        List<Module> ModuleList = new List<Module>();
        List<ClassGroup> ClassGroups = new List<ClassGroup>();
        public AdministratorDashboard()
        {
            InitializeComponent();
            ReadFile<Administrator>(ref AdminList, "AdminFile.dat");

            RefreshAdminDetails();

            ReadFile<Module>(ref ModuleList, "ModuleFile.dat");

            RefreshModuleDetails();

            ReadFile<ClassGroup>(ref ClassGroups, "ClassGroupFile.dat");
        }

        public void RefreshAdminDetails()
        {
            foreach (Administrator admin in AdminList)
            {
                ListViewItem item = new ListViewItem();
                item.Name = admin.AdminID;
                item.Text = admin.AdminID;
                item.SubItems.Add(admin.Name);
                item.SubItems.Add(admin.Address);
                item.SubItems.Add(admin.DateOfBirth.ToShortDateString());
                item.SubItems.Add(admin.PPSNumber);
                item.SubItems.Add(admin.DateOfHire.ToShortDateString());
                this.listViewAdmin.Items.Add(item);
            }
        }

        public void RefreshModuleDetails()
        {
            foreach (Module module in ModuleList)
            {
                string temp = "";
                ListViewItem item = new ListViewItem();
                item.Name = module.ModuleCode;
                item.Text = module.ModuleCode;
                item.SubItems.Add(module.ModuleName);
                item.SubItems.Add(module.Credits.ToString());
                foreach(string s in module.ClassGroups)
                {
                    temp += s + ", ";
                }
                temp = temp.Trim(',',' ');
                item.SubItems.Add(temp);
                this.listViewModule.Items.Add(item);
            }
        }
        private void AdministratorDashboard_Load(object sender, EventArgs e)
        {
            
            /*Administrator A01 = new Administrator("A001", "Admin1", "0835555555", Convert.ToDateTime("12/03/2014"), "Treakle Morrison", Convert.ToDateTime("15/02/1987"), "123 Doll St.", "1234567L");
            Administrator A02 = new Administrator("A002", "Admin1", "1231231234", Convert.ToDateTime("15/06/2017"), "Barry Benson", Convert.ToDateTime("28/11/1994"), "42 Wallaby way", "7654321P");
            AdminList.Add(A01);
            AdminList.Add(A02);
            WriteFile<Administrator>(AdminList, "AdminFile.dat");*/
            /*List<string> ClassGroupNames = new List<string>();
            foreach(ClassGroup cg in ClassGroups)
            {
                ClassGroupNames.Add(cg.ClassGroupName);
            }

            Module M01 = new Module("M001", "Software Testing", 5, ClassGroupNames);
            Module M02 = new Module("M002", "Discrete Mathematics", 5, ClassGroupNames);
            Module M03 = new Module("M003", "Applications Development", 5, ClassGroupNames);
            Module M04 = new Module("M004", "Web Development Fundamentals", 5, ClassGroupNames);
            Module M05 = new Module("M005", "Data Driven Systems", 5, ClassGroupNames);
            Module M06 = new Module("M006", "Computer Science", 5, ClassGroupNames);
            ModuleList.Clear();
            ModuleList.Add(M01);
            ModuleList.Add(M02);
            ModuleList.Add(M03);
            ModuleList.Add(M04);
            ModuleList.Add(M05);
            ModuleList.Add(M06);
            WriteFile<Module>(ModuleList, "ModuleFile.dat");*/


        }
        private void tabPageDashboard_Click(object sender, EventArgs e)
        {

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteFile<Administrator>(AdminList, "AdminFile.dat");
            WriteFile<Module>(ModuleList, "ModuleFile.dat");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadFile<Administrator>(ref AdminList, "AdminFile.dat");
            ReadFile<Module>(ref ModuleList, "ModuleFile.dat");
        }

        private void Administrator_Logout(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 5)
            {
                this.Hide();
                var Login = new Form1();
                Login.Closed += (s, args) => this.Close();
                Login.Show();
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string formHeading = "Add Adminstrator";
            Administrator newAdmin = new Administrator();
            Form adminDetails = new AdminDetails(formHeading);
            DialogResult completeBtn = adminDetails.ShowDialog();
            if (completeBtn == DialogResult.OK)
            {
                newAdmin = (Administrator)adminDetails.Tag;
                AdminList.Add(newAdmin);
            }
            listViewAdmin.Items.Clear();
            RefreshAdminDetails();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if(listViewAdmin.SelectedItems.Count > 0)
            {
                AdminList.RemoveAt(listViewAdmin.Items.IndexOf(listViewAdmin.SelectedItems[0]));
                listViewAdmin.Items.Clear();
                RefreshAdminDetails();
            }
                
        }



        private void btnAddModule_Click_1(object sender, EventArgs e)
        {
            Module newModule = new Module();
            Form moduleDetails = new ModuleDetails();
            DialogResult completeBtn = moduleDetails.ShowDialog();
            if (completeBtn == DialogResult.OK)
            {
                newModule = (Module)moduleDetails.Tag;
                ModuleList.Add(newModule);
            }
            listViewModule.Items.Clear();
            RefreshModuleDetails();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if (listViewModule.SelectedItems.Count > 0)
            {
                Debug.WriteLine(listViewModule.Items.IndexOf(listViewModule.SelectedItems[0]));
                ModuleList.RemoveAt(listViewModule.Items.IndexOf(listViewModule.SelectedItems[0]));
                listViewModule.Items.Clear();
                RefreshModuleDetails();
            }
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            string formHeading = "Edit Adminstrator";
            Administrator newAdmin = new Administrator();
            Form adminDetails = new AdminDetails(formHeading, AdminList[listViewAdmin.Items.IndexOf(listViewAdmin.SelectedItems[0])]);
            DialogResult completeBtn = adminDetails.ShowDialog();
            if (completeBtn == DialogResult.OK)
            {
                newAdmin = (Administrator)adminDetails.Tag;
                AdminList[listViewAdmin.Items.IndexOf(listViewAdmin.SelectedItems[0])] = newAdmin;
            }
            listViewAdmin.Items.Clear();
            RefreshAdminDetails();
        }
    }
}
