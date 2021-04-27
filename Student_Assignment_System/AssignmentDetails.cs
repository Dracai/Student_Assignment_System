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
using System.Text.RegularExpressions;

namespace Student_Assignment_System
{
    public partial class AssignmentDetails : Form
    {
        Lecturer lecturer;
        string cg;
        List<Module> modlist;
        List<Assignment> Assignments;
        Assignment edit;

        public AssignmentDetails(ref Lecturer user, string classgroup = "", Assignment edit = null, string id = null)
        {
            InitializeComponent();
            ReadFiles();

            lecturer = user;
            cg = classgroup;
            if (!(edit == null))
            {
                this.edit = edit;
                txtID.Text = this.edit.AssignmentID;
                txtID.ReadOnly = true;
                txtName.Text = this.edit.Name;
                txtDescript.Text = this.edit.Description;
                txtCG.Text = this.edit.ClassGroup;
                dtpDue.Value = this.edit.DateDue;
                foreach (Module s in modlist)
                {
                    if (user.ModulesToTeach.Contains(s.ModuleCode))
                        cbModule.Items.Add(s.ModuleName);
                }
                cbModule.SelectedIndex = cbModule.Items.IndexOf(this.edit.Module);
            }
            else
            {
                txtID.Text = id;
                txtCG.Text = cg;
                foreach (Module s in modlist)
                {
                    if (user.ModulesToTeach.Contains(s.ModuleCode))
                        cbModule.Items.Add(s.ModuleName);
                }
            }

            if (id == null)
                txtID.ReadOnly = false;
            else
            {
                txtID.Text = id;
                txtID.ReadOnly = true;
            }

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                Assignment assignment = new Assignment(txtID.Text, txtName.Text, DateTime.Now, dtpDue.Value, txtCG.Text, cbModule.Text, lecturer.LecturerID, txtDescript.Text);
                edit = assignment;
                this.Tag = edit;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        public bool validateInput()
        {
            
            if (String.IsNullOrEmpty(txtDescript.Text))
            {
                MessageBox.Show("Assignment requires short Description");
                return false;
            }
            else if (dtpDue.Value < DateTime.Today)
            {
                MessageBox.Show("Select a valid date");
                return false;
            }
            else if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Assignment Requires ID");
                return false;
            }
            else if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name text box cannot be empty");
                return false;
            }
            else if (String.IsNullOrEmpty(cbModule.Text))
            {
                MessageBox.Show("Please Select a Module to Assign to this Assignment");
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

        private void ReadFiles()
        {
            ReadFile<Module>(ref modlist, "ModuleFile.dat");
            ReadFile<Assignment>(ref Assignments, "AssignmentFiles.dat");
        }


    }
}
