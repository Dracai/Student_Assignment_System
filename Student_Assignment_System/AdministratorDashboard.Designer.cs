
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdmins = new System.Windows.Forms.TabPage();
            this.tabPageLects = new System.Windows.Forms.TabPage();
            this.tabPageStuds = new System.Windows.Forms.TabPage();
            this.tabPageModules = new System.Windows.Forms.TabPage();
            this.tabPageLogOut = new System.Windows.Forms.TabPage();
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.columnHeaderAdminID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPPSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateOfHire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewModule = new System.Windows.Forms.ListView();
            this.columnHeaderModCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClassGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlAdmin.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.tabPageAdmins.SuspendLayout();
            this.tabPageModules.SuspendLayout();
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
            this.tabPageDashboard.Controls.Add(this.btnRead);
            this.tabPageDashboard.Controls.Add(this.btnSave);
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
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(364, 255);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 255);
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
            // tabPageLogOut
            // 
            this.tabPageLogOut.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogOut.Name = "tabPageLogOut";
            this.tabPageLogOut.Size = new System.Drawing.Size(768, 393);
            this.tabPageLogOut.TabIndex = 5;
            this.tabPageLogOut.Text = "Log Out";
            this.tabPageLogOut.UseVisualStyleBackColor = true;
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
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdministratorDashboard";
            this.Text = "Administrator Dashboard";
            this.Load += new System.EventHandler(this.AdministratorDashboard_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.tabPageAdmins.ResumeLayout(false);
            this.tabPageModules.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRead;
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
    }
}