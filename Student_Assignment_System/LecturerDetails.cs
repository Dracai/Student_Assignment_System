﻿using System;
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
    public partial class LecturerDetails : Form
    {
        public LecturerDetails(string detailsHeading, Lecturer selectedLecturer = null)
        {
            InitializeComponent();
            if(!(selectedLecturer == null))
            {
                txtLecturerID.Text = selectedLecturer.LecturerID;
                txtLecturerName.Text = selectedLecturer.Name;
                dtpLecturerDOB.Value = selectedLecturer.DateOfBirth;
                txtLecturerAddress.Text = selectedLecturer.Address;
                txtLecturerPPSN.Text = selectedLecturer.PPSNumber;
                txtLecturerPassword.Text = selectedLecturer.LecturerPassword;
                string temp = "";
                foreach (string module in selectedLecturer.ModulesToTeach)
                {
                    temp += module + ", ";
                }
                temp = temp.TrimEnd(',', ' ');
                txtLecturerModuleToTeach.Text = temp;
                dtpLecturerDateOfHire.Value = selectedLecturer.DateOfHire;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                List<string> modulesToTeach = new List<string>(txtLecturerModuleToTeach.Text.Split(',').ToList());
                Lecturer lect = new Lecturer(txtLecturerName.Text,dtpLecturerDOB.Value,txtLecturerAddress.Text,txtLecturerPPSN.Text,txtLecturerID.Text,txtLecturerPassword.Text,modulesToTeach,dtpLecturerDateOfHire.Value);
                this.Tag = lect;
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