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
    public partial class ModuleDetails : Form
    {
        private List<ClassGroup> classgrouplist = new List<ClassGroup>();
        private List<string> classgrouplistNames = new List<string>();
        public ModuleDetails()
        {
            InitializeComponent();
        }

        private void ModuleDetails_Load(object sender, EventArgs e)
        {
            ReadFile<ClassGroup>(ref classgrouplist, "ClassGroupsFile.dat");
            foreach (ClassGroup cg in classgrouplist)
            {
                clbClassGroups.Items.Add(cg.ClassGroupName);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                List<string> ClassGroupsToAdd = new List<string>();
                foreach (Object item in clbClassGroups.CheckedItems)
                {
                    ClassGroupsToAdd.Add(item.ToString());
                }
                Module module = new Module(txtModuleCode.Text, txtModuleName.Text, Convert.ToInt32(txtModuleCredits.Text),ClassGroupsToAdd);
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
