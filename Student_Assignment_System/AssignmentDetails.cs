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
        List<ClassGroup> classGroupslist;
        List<Module> modlist;
        List<Assignment> Assignments;

        public AssignmentDetails(ref Lecturer user,List<Module> mod,List<ClassGroup> classGroups,List<Assignment> assignments)
        {
            InitializeComponent();
            lecturer = user;
            classGroupslist = classGroups;
            modlist = mod;
            Assignments = assignments;
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
                Assignment assignment = new Assignment(txtID.Text, txtName.Text, DateTime.Now, dtpDue.Value, cbClassGroup.Text, cbModule.Text, lecturer.LecturerID, txtDescript.Text);
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
