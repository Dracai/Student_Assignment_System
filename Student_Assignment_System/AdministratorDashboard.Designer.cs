
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
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
            this.lblModuleHeading = new System.Windows.Forms.Label();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnEditModule = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.listViewModule = new System.Windows.Forms.ListView();
            this.columnHeaderModCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClassGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageLogOut = new System.Windows.Forms.TabPage();
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
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1025, 426);
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
            this.tabPageDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDashboard.Size = new System.Drawing.Size(1017, 393);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            this.tabPageDashboard.Click += new System.EventHandler(this.tabPageDashboard_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(591, 340);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, {User}";
            // 
            // tabPageAdmins
            // 
            this.tabPageAdmins.Controls.Add(this.label2);
            this.tabPageAdmins.Controls.Add(this.btnDeleteAdmin);
            this.tabPageAdmins.Controls.Add(this.btnEditAdmin);
            this.tabPageAdmins.Controls.Add(this.btnAddAdmin);
            this.tabPageAdmins.Controls.Add(this.listViewAdmin);
            this.tabPageAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdmins.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdmins.Name = "tabPageAdmins";
            this.tabPageAdmins.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdmins.Size = new System.Drawing.Size(1017, 393);
            this.tabPageAdmins.TabIndex = 1;
            this.tabPageAdmins.Text = "Administrators";
            this.tabPageAdmins.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrators";
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(707, 272);
            this.btnDeleteAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(285, 39);
            this.btnDeleteAdmin.TabIndex = 3;
            this.btnDeleteAdmin.Text = "Delete Admin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.Location = new System.Drawing.Point(364, 272);
            this.btnEditAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(285, 39);
            this.btnEditAdmin.TabIndex = 2;
            this.btnEditAdmin.Text = "Edit Admin";
            this.btnEditAdmin.UseVisualStyleBackColor = true;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(24, 272);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(285, 39);
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAdminID,
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderDOB,
            this.columnHeaderPPSN,
            this.columnHeaderDateOfHire});
            this.listViewAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAdmin.FullRowSelect = true;
            this.listViewAdmin.GridLines = true;
            this.listViewAdmin.HideSelection = false;
            this.listViewAdmin.Location = new System.Drawing.Point(8, 59);
            this.listViewAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewAdmin.MultiSelect = false;
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(1003, 176);
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
            this.tabPageLects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLects.Name = "tabPageLects";
            this.tabPageLects.Size = new System.Drawing.Size(1017, 393);
            this.tabPageLects.TabIndex = 2;
            this.tabPageLects.Text = "Lecturers";
            this.tabPageLects.UseVisualStyleBackColor = true;
            // 
            // tabPageStuds
            // 
            this.tabPageStuds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStuds.Location = new System.Drawing.Point(4, 29);
            this.tabPageStuds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStuds.Name = "tabPageStuds";
            this.tabPageStuds.Size = new System.Drawing.Size(1017, 393);
            this.tabPageStuds.TabIndex = 3;
            this.tabPageStuds.Text = "Students";
            this.tabPageStuds.UseVisualStyleBackColor = true;
            // 
            // tabPageModules
            // 
            this.tabPageModules.Controls.Add(this.lblModuleHeading);
            this.tabPageModules.Controls.Add(this.btnDeleteModule);
            this.tabPageModules.Controls.Add(this.btnEditModule);
            this.tabPageModules.Controls.Add(this.btnAddModule);
            this.tabPageModules.Controls.Add(this.listViewModule);
            this.tabPageModules.Location = new System.Drawing.Point(4, 29);
            this.tabPageModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageModules.Name = "tabPageModules";
            this.tabPageModules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageModules.Size = new System.Drawing.Size(1017, 393);
            this.tabPageModules.TabIndex = 4;
            this.tabPageModules.Text = "Modules";
            this.tabPageModules.UseVisualStyleBackColor = true;
            // 
            // lblModuleHeading
            // 
            this.lblModuleHeading.AutoSize = true;
            this.lblModuleHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleHeading.Location = new System.Drawing.Point(413, 20);
            this.lblModuleHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleHeading.Name = "lblModuleHeading";
            this.lblModuleHeading.Size = new System.Drawing.Size(106, 29);
            this.lblModuleHeading.TabIndex = 7;
            this.lblModuleHeading.Text = "Modules";
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Location = new System.Drawing.Point(704, 297);
            this.btnDeleteModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(285, 39);
            this.btnDeleteModule.TabIndex = 6;
            this.btnDeleteModule.Text = "Delete Module";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnEditModule
            // 
            this.btnEditModule.Location = new System.Drawing.Point(367, 297);
            this.btnEditModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditModule.Name = "btnEditModule";
            this.btnEditModule.Size = new System.Drawing.Size(285, 39);
            this.btnEditModule.TabIndex = 5;
            this.btnEditModule.Text = "Edit Module";
            this.btnEditModule.UseVisualStyleBackColor = true;
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(27, 297);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(285, 39);
            this.btnAddModule.TabIndex = 4;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click_1);
            // 
            // listViewModule
            // 
            this.listViewModule.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewModule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderModCode,
            this.columnHeaderModName,
            this.columnHeaderCredits,
            this.columnHeaderClassGroups});
            this.listViewModule.FullRowSelect = true;
            this.listViewModule.GridLines = true;
            this.listViewModule.HideSelection = false;
            this.listViewModule.Location = new System.Drawing.Point(6, 70);
            this.listViewModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewModule.Name = "listViewModule";
            this.listViewModule.Size = new System.Drawing.Size(1008, 204);
            this.listViewModule.TabIndex = 0;
            this.listViewModule.UseCompatibleStateImageBehavior = false;
            this.listViewModule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderModCode
            // 
            this.columnHeaderModCode.Text = "Code";
            this.columnHeaderModCode.Width = 104;
            // 
            // columnHeaderModName
            // 
            this.columnHeaderModName.Text = "Name";
            this.columnHeaderModName.Width = 277;
            // 
            // columnHeaderCredits
            // 
            this.columnHeaderCredits.Text = "Credits";
            this.columnHeaderCredits.Width = 143;
            // 
            // columnHeaderClassGroups
            // 
            this.columnHeaderClassGroups.Text = "ClassGroups";
            this.columnHeaderClassGroups.Width = 228;
            // 
            // tabPageLogOut
            // 
            this.tabPageLogOut.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLogOut.Name = "tabPageLogOut";
            this.tabPageLogOut.Size = new System.Drawing.Size(1017, 393);
            this.tabPageLogOut.TabIndex = 5;
            this.tabPageLogOut.Text = "Log Out";
            this.tabPageLogOut.UseVisualStyleBackColor = true;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorDashboard";
            this.Text = "Administrator Dashboard";
            this.Load += new System.EventHandler(this.AdministratorDashboard_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.tabPageAdmins.ResumeLayout(false);
            this.tabPageAdmins.PerformLayout();
            this.tabPageModules.ResumeLayout(false);
            this.tabPageModules.PerformLayout();
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
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModuleHeading;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnEditModule;
        private System.Windows.Forms.Button btnAddModule;
    }
}