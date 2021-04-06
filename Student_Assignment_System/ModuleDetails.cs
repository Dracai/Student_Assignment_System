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
    public partial class ModuleDetails : Form
    {
        public ModuleDetails()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                Module module = new Module(txtModuleCode.Text, txtModuleName.Text, Convert.ToInt32(txtModuleCredits.Text));
                this.Tag = module;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //Validate your shit son

            }
        }

        public bool validateInput()
        {
            return true;
        }
    }
}
