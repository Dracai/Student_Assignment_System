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

namespace Student_Assignment_System
{
    public partial class AssignmentDetails : Form
    {
        Lecturer lecturer;
        string cg;
        List<Module> modlist;
        List<Assignment> Assignments;
        Assignment edit;

        public AssignmentDetails(ref Lecturer user, string classgroup = "", Assignment edit = null)
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
                txtCG.Text = cg;
                foreach (Module s in modlist)
                {
                    if (user.ModulesToTeach.Contains(s.ModuleCode))
                        cbModule.Items.Add(s.ModuleName);
                }
            }

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string error = "";
            bool check = validateInput(ref error);
            if (check)
            {
                Assignment assignment = new Assignment(txtID.Text, txtName.Text, DateTime.Now, dtpDue.Value, txtCG.Text, cbModule.Text, lecturer.LecturerID, txtDescript.Text);
                this.Tag = assignment;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(error,"Invalid Data Entered");
            }
        }

        public bool validateInput(ref string error)
        {
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
            ReadFile<Assignment>(ref Assignments, "Assignments.dat");
        }


    }
}
