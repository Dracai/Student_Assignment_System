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
    public partial class UpcomingAssignments : Form
    {
        List<Assignment> assignments;
        public UpcomingAssignments(string cg, string period)
        {
            InitializeComponent();
            lblCg.Text = cg;
            ReadFile<Assignment>(ref assignments, "AssignmentFiles.dat");
            ListViewItem item;
            DateTime cutoff = DateTime.Now;
            if(period=="Week")
            {
                foreach (Assignment a in assignments)
                {
                    if (a.ClassGroup == cg && (a.DateDue > (DateTime.Now.AddDays(-1))))
                    {

                        item = new ListViewItem(a.AssignmentID);
                        item.SubItems.Add(a.Name);
                        item.SubItems.Add(a.Module);
                        item.SubItems.Add(a.DateDue.ToShortDateString().ToString());
                        lvUpcomingAssignment.Items.Add(item);
                    }
                }
            }
            else if(period=="Month")
            {
                foreach (Assignment a in assignments)
                {
                    if (a.ClassGroup == cg && (a.DateDue > (DateTime.Now.AddDays(-1)) && a.DateDue < DateTime.Now.AddDays(30)))
                    {
                        item = new ListViewItem(a.AssignmentID);
                        item.SubItems.Add(a.Name);
                        item.SubItems.Add(a.Module);
                        item.SubItems.Add(a.DateDue.ToShortDateString().ToString());
                        lvUpcomingAssignment.Items.Add(item);
                    }
                }
            }

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

        private void btnViewDescription_Click(object sender, EventArgs e)
        {
            if (lvUpcomingAssignment.SelectedItems.Count > 0)
            {
                foreach (Assignment a in assignments)
                {
                    if (a.AssignmentID == lvUpcomingAssignment.SelectedItems[0].Text)
                    {
                        MessageBox.Show(a.Description);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select An Assignment", "Error");
            }
        }
    }
}
