
namespace Student_Assignment_System
{
    partial class AdministratorDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdmins = new System.Windows.Forms.TabPage();
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.columnHeaderAdminID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPPSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateOfHire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageLects = new System.Windows.Forms.TabPage();
            this.tabPageStuds = new System.Windows.Forms.TabPage();
            this.tabPageModules = new System.Windows.Forms.TabPage();
            this.listViewModule = new System.Windows.Forms.ListView();
            this.columnHeaderModCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClassGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageLogOut = new System.Windows.Forms.TabPage();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.gbLecturer = new System.Windows.Forms.GroupBox();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.gbModule = new System.Windows.Forms.GroupBox();
            this.lblAdminDB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.tabPageAdmins.SuspendLayout();
            this.tabPageModules.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.gbLecturer.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.gbModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageDashboard);
            this.tabControlAdmin.Controls.Add(this.tabPageAdmins);
            this.tabControlAdmin.Controls.Add(this.tabPageLects);
            this.tabControlAdmin.Controls.Add(this.tabPageStuds);
            this.tabControlAdmin.Controls.Add(this.tabPageModules);
            this.tabControlAdmin.Controls.Add(this.tabPageLogOut);
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(776, 426);
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.Administrator_Logout);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.gbModule);
            this.tabPageDashboard.Controls.Add(this.gbStudent);
            this.tabPageDashboard.Controls.Add(this.gbLecturer);
            this.tabPageDashboard.Controls.Add(this.gbAdmin);
            this.tabPageDashboard.Controls.Add(this.label1);
            this.tabPageDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 29);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(768, 393);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            this.tabPageDashboard.Click += new System.EventHandler(this.tabPageDashboard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(709, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, {User}";
            // 
            // tabPageAdmins
            // 
            this.tabPageAdmins.Controls.Add(this.listViewAdmin);
            this.tabPageAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdmins.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmins.Name = "tabPageAdmins";
            this.tabPageAdmins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmins.Size = new System.Drawing.Size(768, 393);
            this.tabPageAdmins.TabIndex = 1;
            this.tabPageAdmins.Text = "Administrators";
            this.tabPageAdmins.UseVisualStyleBackColor = true;
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAdminID,
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderDOB,
            this.columnHeaderPPSN,
            this.columnHeaderDateOfHire});
            this.listViewAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAdmin.GridLines = true;
            this.listViewAdmin.HideSelection = false;
            this.listViewAdmin.Location = new System.Drawing.Point(6, 37);
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(756, 176);
            this.listViewAdmin.TabIndex = 0;
            this.listViewAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewAdmin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAdminID
            // 
            this.columnHeaderAdminID.Text = "Admin ID";
            this.columnHeaderAdminID.Width = 85;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Full Name";
            this.columnHeaderName.Width = 163;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 140;
            // 
            // columnHeaderDOB
            // 
            this.columnHeaderDOB.Text = "DOB";
            this.columnHeaderDOB.Width = 118;
            // 
            // columnHeaderPPSN
            // 
            this.columnHeaderPPSN.Text = "PPSN";
            this.columnHeaderPPSN.Width = 115;
            // 
            // columnHeaderDateOfHire
            // 
            this.columnHeaderDateOfHire.Text = "Date Of Hire";
            this.columnHeaderDateOfHire.Width = 127;
            // 
            // tabPageLects
            // 
            this.tabPageLects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLects.Location = new System.Drawing.Point(4, 29);
            this.tabPageLects.Name = "tabPageLects";
            this.tabPageLects.Size = new System.Drawing.Size(768, 393);
            this.tabPageLects.TabIndex = 2;
            this.tabPageLects.Text = "Lecturers";
            this.tabPageLects.UseVisualStyleBackColor = true;
            // 
            // tabPageStuds
            // 
            this.tabPageStuds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStuds.Location = new System.Drawing.Point(4, 29);
            this.tabPageStuds.Name = "tabPageStuds";
            this.tabPageStuds.Size = new System.Drawing.Size(768, 393);
            this.tabPageStuds.TabIndex = 3;
            this.tabPageStuds.Text = "Students";
            this.tabPageStuds.UseVisualStyleBackColor = true;
            // 
            // tabPageModules
            // 
            this.tabPageModules.Controls.Add(this.listViewModule);
            this.tabPageModules.Location = new System.Drawing.Point(4, 29);
            this.tabPageModules.Name = "tabPageModules";
            this.tabPageModules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageModules.Size = new System.Drawing.Size(768, 393);
            this.tabPageModules.TabIndex = 4;
            this.tabPageModules.Text = "Modules";
            this.tabPageModules.UseVisualStyleBackColor = true;
            // 
            // listViewModule
            // 
            this.listViewModule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderModCode,
            this.columnHeaderModName,
            this.columnHeaderCredits,
            this.columnHeaderClassGroups});
            this.listViewModule.GridLines = true;
            this.listViewModule.HideSelection = false;
            this.listViewModule.Location = new System.Drawing.Point(3, 15);
            this.listViewModule.Name = "listViewModule";
            this.listViewModule.Size = new System.Drawing.Size(762, 242);
            this.listViewModule.TabIndex = 0;
            this.listViewModule.UseCompatibleStateImageBehavior = false;
            this.listViewModule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderModCode
            // 
            this.columnHeaderModCode.Text = "Code";
            // 
            // columnHeaderModName
            // 
            this.columnHeaderModName.Text = "Name";
            // 
            // columnHeaderCredits
            // 
            this.columnHeaderCredits.Text = "Credits";
            this.columnHeaderCredits.Width = 77;
            // 
            // columnHeaderClassGroups
            // 
            this.columnHeaderClassGroups.Text = "ClassGroups";
            this.columnHeaderClassGroups.Width = 116;
            // 
            // tabPageLogOut
            // 
            this.tabPageLogOut.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogOut.Name = "tabPageLogOut";
            this.tabPageLogOut.Size = new System.Drawing.Size(768, 393);
            this.tabPageLogOut.TabIndex = 5;
            this.tabPageLogOut.Text = "Log Out";
            this.tabPageLogOut.UseVisualStyleBackColor = true;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnAdmin);
            this.gbAdmin.Controls.Add(this.lblAdminDB);
            this.gbAdmin.Location = new System.Drawing.Point(22, 110);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(176, 221);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Adminstrators";
            // 
            // gbLecturer
            // 
            this.gbLecturer.Controls.Add(this.btnLecturer);
            this.gbLecturer.Controls.Add(this.label2);
            this.gbLecturer.Location = new System.Drawing.Point(204, 110);
            this.gbLecturer.Name = "gbLecturer";
            this.gbLecturer.Size = new System.Drawing.Size(176, 221);
            this.gbLecturer.TabIndex = 2;
            this.gbLecturer.TabStop = false;
            this.gbLecturer.Text = "Lecturers";
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.btnStudent);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Location = new System.Drawing.Point(386, 110);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(176, 221);
            this.gbStudent.TabIndex = 2;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Students";
            // 
            // gbModule
            // 
            this.gbModule.Controls.Add(this.btnModule);
            this.gbModule.Controls.Add(this.label4);
            this.gbModule.Location = new System.Drawing.Point(568, 110);
            this.gbModule.Name = "gbModule";
            this.gbModule.Size = new System.Drawing.Size(176, 221);
            this.gbModule.TabIndex = 3;
            this.gbModule.TabStop = false;
            this.gbModule.Text = "Modules";
            // 
            // lblAdminDB
            // 
            this.lblAdminDB.AutoSize = true;
            this.lblAdminDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDB.Location = new System.Drawing.Point(3, 41);
            this.lblAdminDB.Name = "lblAdminDB";
            this.lblAdminDB.Size = new System.Drawing.Size(167, 60);
            this.lblAdminDB.TabIndex = 0;
            this.lblAdminDB.Text = "Manage all the \r\nadministrators in the \r\ndatabase";
            this.lblAdminDB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage all the \r\nlecturers in the \r\ndatabase";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage all the \r\nstudents in the \r\ndatabase";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 60);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manage all the \r\nmodules in the \r\ndatabase";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(7, 169);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(163, 46);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Manage";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.Location = new System.Drawing.Point(7, 169);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(163, 46);
            this.btnLecturer.TabIndex = 2;
            this.btnLecturer.Text = "Manage";
            this.btnLecturer.UseVisualStyleBackColor = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(7, 169);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(163, 46);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Manage";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnModule
            // 
            this.btnModule.Location = new System.Drawing.Point(6, 169);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(163, 46);
            this.btnModule.TabIndex = 4;
            this.btnModule.Text = "Manage";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.btnSave);
            this.Name = "AdministratorDashboard";
            this.Text = "Administrator Dashboard";
            this.Load += new System.EventHandler(this.AdministratorDashboard_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.tabPageAdmins.ResumeLayout(false);
            this.tabPageModules.ResumeLayout(false);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbLecturer.ResumeLayout(false);
            this.gbLecturer.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbModule.ResumeLayout(false);
            this.gbModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageAdmins;
        private System.Windows.Forms.TabPage tabPageLects;
        private System.Windows.Forms.TabPage tabPageStuds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageModules;
        private System.Windows.Forms.TabPage tabPageLogOut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listViewAdmin;
        private System.Windows.Forms.ColumnHeader columnHeaderAdminID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderDOB;
        private System.Windows.Forms.ColumnHeader columnHeaderPPSN;
        private System.Windows.Forms.ColumnHeader columnHeaderDateOfHire;
        private System.Windows.Forms.ListView listViewModule;
        private System.Windows.Forms.ColumnHeader columnHeaderModCode;
        private System.Windows.Forms.ColumnHeader columnHeaderModName;
        private System.Windows.Forms.ColumnHeader columnHeaderCredits;
        private System.Windows.Forms.ColumnHeader columnHeaderClassGroups;
        private System.Windows.Forms.GroupBox gbModule;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLecturer;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblAdminDB;
    }
}