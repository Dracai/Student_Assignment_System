using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assignment_System
{
    public partial class ModuleDetails : Form
    {
        List<ClassGroup> ClassGroups = new List<ClassGroup>();
        public ModuleDetails(string moduleHeading, Module selectedModule = null)
        {
            InitializeComponent();
            ReadFile<ClassGroup>(ref ClassGroups, "ClassGroupFile.dat");
            foreach(ClassGroup cg in ClassGroups)
            {
                clbClassGroups.Items.Add(cg.ClassGroupName);
            }

            lblModuleHeading.Text = moduleHeading;
            if(!(selectedModule == null))
            {
                txtModuleCode.Text = selectedModule.ModuleCode;
                txtModuleName.Text = selectedModule.ModuleName;
                txtModuleCredits.Text = selectedModule.Credits.ToString();
                List<string> itemsToCheck = new List<string>();
                foreach(string cg in clbClassGroups.Items)
                {
                    if (selectedModule.ClassGroups.Contains(cg))
                        itemsToCheck.Add(cg);
                }
                foreach(string item in itemsToCheck)
                {
                    clbClassGroups.SetItemChecked(clbClassGroups.Items.IndexOf(item), true);
                }

            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                List<string> moduleClassGroups = new List<string>();
                foreach (string cg in clbClassGroups.CheckedItems)
                {
                    moduleClassGroups.Add(cg);
                }
                Module module = new Module(txtModuleCode.Text, txtModuleName.Text, Convert.ToInt32(txtModuleCredits.Text), moduleClassGroups);
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
