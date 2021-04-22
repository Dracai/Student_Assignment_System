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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Student_Assignment_System
{
    public partial class LecturerDetails : Form
    {
        public List<Module> moduleList = new List<Module>();
        public LecturerDetails(string detailsHeading, Lecturer selectedLecturer = null)
        {
            InitializeComponent();
            lblLectDetailsheading.Text = detailsHeading;
            ReadFile<Module>(ref moduleList, "ModuleFile.dat");
            foreach (Module m in moduleList)
            {
                clbModulesToTeach.Items.Add(m.ModuleName);
            }
            txtLecturerID.ReadOnly = true;
            if (!(selectedLecturer == null))
            {
                //txtLecturerID.ReadOnly = true;
                txtLecturerID.Text = selectedLecturer.LecturerID;
                txtLecturerName.Text = selectedLecturer.Name;
                dtpLecturerDOB.Value = selectedLecturer.DateOfBirth;
                txtLecturerAddress.Text = selectedLecturer.Address;
                txtLecturerPPSN.Text = selectedLecturer.PPSNumber;
                txtLecturerPassword.Text = selectedLecturer.LecturerPassword;

                
                List<string> itemsToCheck = new List<string>();
                foreach(Module module in moduleList)
                {
                    if(selectedLecturer.ModulesToTeach.Contains(module.ModuleCode))
                    {
                        itemsToCheck.Add(module.ModuleName);
                        Debug.Write(module.ModuleName);
                    }
                    
                }
                
                foreach(string item in itemsToCheck)
                {
                    clbModulesToTeach.SetItemChecked(clbModulesToTeach.Items.IndexOf(item), true);
                }
                dtpLecturerDateOfHire.Value = selectedLecturer.DateOfHire;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                List<Lecturer> lectList = new List<Lecturer>();
                ReadFile<Lecturer>(ref lectList, "LecturerFiles.dat");
                List<string> lectIDs = lectList.Select(_ => _.LecturerID).ToList();
                List<string> modulesToTeach = new List<string>();
                foreach(string module in clbModulesToTeach.CheckedItems)
                {
                    foreach(Module m in moduleList)
                    {
                        if(module == m.ModuleName)
                        {
                            modulesToTeach.Add(m.ModuleCode);
                        }
                    }
                }
                Random random = new Random();
                string lectID = $"L{random.Next(100, 999)}";
                while (lectIDs.Contains(lectID))
                {
                    lectID = $"L{random.Next(100, 999)}";
                }
                Lecturer lect = new Lecturer(lectID,dtpLecturerDOB.Value,txtLecturerAddress.Text,txtLecturerPPSN.Text,txtLecturerID.Text,txtLecturerPassword.Text,modulesToTeach,dtpLecturerDateOfHire.Value);
                this.Tag = lect;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public bool validateInput()
        {
            if (!Regex.IsMatch(txtLecturerName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name has to contain alphabetic characters only");
                return false;
            }
            else if (String.IsNullOrEmpty(txtLecturerName.Text))
            {
                MessageBox.Show("Name text box cannot be empty");
                return false;
            }
            else if (dtpLecturerDOB.Value >= DateTime.Today)
            {
                MessageBox.Show("Select a valid date of birth");
                return false;
            }
            else if (String.IsNullOrEmpty(txtLecturerAddress.Text))
            {
                MessageBox.Show("Address text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtLecturerPPSN.Text))
            {
                MessageBox.Show("PPS number  text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(txtLecturerPassword.Text))
            {
                MessageBox.Show("Password text box cannot be empty");
                return false;
            }
            else if (dtpLecturerDateOfHire.Value >= dtpLecturerDOB.Value)
            {
                MessageBox.Show("Pick a valid date of hire");
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
