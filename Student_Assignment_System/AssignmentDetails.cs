using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assignment_System
{
    public partial class AssignmentDetails : Form
    {
        Lecturer lecturer;
        string cg;
        List<Module> modlist;
        List<Assignment> Assignments;
        Assignment edit;

        public AssignmentDetails(ref Lecturer user,List<Module> mod,List<Assignment> assignments, string classgroup = "", Assignment edit = null)
        {
            InitializeComponent();
            
            if (edit!=null)
            {
                txtID.Text = edit.AssignmentID;
                txtName.Text = edit.Name;
                txtDescript.Text = edit.Description;
                txtCG.Text = edit.ClassGroup;
                foreach (Module s in modlist)
                {
                    if (user.ModulesToTeach.Contains(s.ModuleCode))
                        cbModule.Items.Add(s.ModuleName);
                }
               
            }
            lecturer = user;
            cg = classgroup;
            modlist = mod;
            Assignments = assignments;
            txtCG.Text = cg;
            foreach(Module s in modlist)
            {
                if (user.ModulesToTeach.Contains(s.ModuleCode))
                    cbModule.Items.Add(s.ModuleName);
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
    }
}
