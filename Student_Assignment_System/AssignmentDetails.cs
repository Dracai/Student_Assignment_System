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

        public AssignmentDetails(ref Lecturer user,List<Module> mod,List<ClassGroup> classGroups)
        {
            InitializeComponent();
            lecturer = user;
            classGroupslist = classGroups;
            modlist = mod;
            foreach(Module s in modlist)
            {
                if (user.ModulesToTeach.Contains(s.ModuleCode))
                    cbModule.Items.Add(s.ModuleName);
            }
            /*
            foreach (Module s in modlist)
            {
                if (user.ModulesToTeach.Contains(s.ModuleCode)) 
                    cbClassGroup.Items.AddRange(s.ClassGroups);
            }
            */

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                Assignment assignment = new Assignment(txtID.Text, txtName.Text, DateTime.Now, dtpDue.Value, cbClassGroup.Text, cbModule.Text, lecturer.LecturerID, txtDescript.Text);
                this.Tag = assignment;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Data Entered");
            }
        }

        public bool validateInput()
        {
            return true;
        }
    }
}
