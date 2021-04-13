
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpbModules = new System.Windows.Forms.GroupBox();
            this.btnModule = new System.Windows.Forms.Button();
            this.grpbStuds = new System.Windows.Forms.GroupBox();
            this.btnStud = new System.Windows.Forms.Button();
            this.grpbLects = new System.Windows.Forms.GroupBox();
            this.btnLect = new System.Windows.Forms.Button();
            this.grpbAdmins = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDashboardHeading = new System.Windows.Forms.Label();
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
            this.lblLecturerHeading = new System.Windows.Forms.Label();
            this.btnDeleteLect = new System.Windows.Forms.Button();
            this.btnEditLect = new System.Windows.Forms.Button();
            this.btnAddLect = new System.Windows.Forms.Button();
            this.listViewLecturer = new System.Windows.Forms.ListView();
            this.columnHeaderLectID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectPPSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectDateOfHire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.columnHeaderStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentPPSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentDateEnrolled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLectModulesToTeach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStudentClassGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlAdmin.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.grpbModules.SuspendLayout();
            this.grpbStuds.SuspendLayout();
            this.grpbLects.SuspendLayout();
            this.grpbAdmins.SuspendLayout();
            this.tabPageAdmins.SuspendLayout();
            this.tabPageLects.SuspendLayout();
            this.tabPageStuds.SuspendLayout();
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
            this.tabControlAdmin.Size = new System.Drawing.Size(1309, 426);
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.Administrator_Logout);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.label1);
            this.tabPageDashboard.Controls.Add(this.grpbModules);
            this.tabPageDashboard.Controls.Add(this.grpbStuds);
            this.tabPageDashboard.Controls.Add(this.grpbLects);
            this.tabPageDashboard.Controls.Add(this.grpbAdmins);
            this.tabPageDashboard.Controls.Add(this.btnRead);
            this.tabPageDashboard.Controls.Add(this.btnSave);
            this.tabPageDashboard.Controls.Add(this.lblDashboardHeading);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage:";
            // 
            // grpbModules
            // 
            this.grpbModules.Controls.Add(this.btnModule);
            this.grpbModules.Location = new System.Drawing.Point(752, 223);
            this.grpbModules.Name = "grpbModules";
            this.grpbModules.Size = new System.Drawing.Size(234, 165);
            this.grpbModules.TabIndex = 4;
            this.grpbModules.TabStop = false;
            this.grpbModules.Text = "Modules";
            // 
            // btnModule
            // 
            this.btnModule.Location = new System.Drawing.Point(6, 82);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(222, 34);
            this.btnModule.TabIndex = 3;
            this.btnModule.Text = "Go";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // grpbStuds
            // 
            this.grpbStuds.Controls.Add(this.btnStud);
            this.grpbStuds.Location = new System.Drawing.Point(512, 223);
            this.grpbStuds.Name = "grpbStuds";
            this.grpbStuds.Size = new System.Drawing.Size(234, 165);
            this.grpbStuds.TabIndex = 4;
            this.grpbStuds.TabStop = false;
            this.grpbStuds.Text = "Students";
            // 
            // btnStud
            // 
            this.btnStud.Location = new System.Drawing.Point(6, 82);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(222, 34);
            this.btnStud.TabIndex = 2;
            this.btnStud.Text = "Go";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // grpbLects
            // 
            this.grpbLects.Controls.Add(this.btnLect);
            this.grpbLects.Location = new System.Drawing.Point(272, 223);
            this.grpbLects.Name = "grpbLects";
            this.grpbLects.Size = new System.Drawing.Size(234, 165);
            this.grpbLects.TabIndex = 4;
            this.grpbLects.TabStop = false;
            this.grpbLects.Text = "Lecturers";
            // 
            // btnLect
            // 
            this.btnLect.Location = new System.Drawing.Point(6, 82);
            this.btnLect.Name = "btnLect";
            this.btnLect.Size = new System.Drawing.Size(222, 34);
            this.btnLect.TabIndex = 1;
            this.btnLect.Text = "Go";
            this.btnLect.UseVisualStyleBackColor = true;
            this.btnLect.Click += new System.EventHandler(this.btnLect_Click);
            // 
            // grpbAdmins
            // 
            this.grpbAdmins.Controls.Add(this.btnAdmin);
            this.grpbAdmins.Location = new System.Drawing.Point(32, 223);
            this.grpbAdmins.Name = "grpbAdmins";
            this.grpbAdmins.Size = new System.Drawing.Size(234, 165);
            this.grpbAdmins.TabIndex = 3;
            this.grpbAdmins.TabStop = false;
            this.grpbAdmins.Text = "Administrators";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(6, 82);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(222, 34);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Go";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(915, 39);
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
            this.btnSave.Location = new System.Drawing.Point(6, 39);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDashboardHeading
            // 
            this.lblDashboardHeading.AutoSize = true;
            this.lblDashboardHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardHeading.Location = new System.Drawing.Point(329, 35);
            this.lblDashboardHeading.Name = "lblDashboardHeading";
            this.lblDashboardHeading.Size = new System.Drawing.Size(237, 36);
            this.lblDashboardHeading.TabIndex = 0;
            this.lblDashboardHeading.Text = "Welcome, {User}";
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
            this.tabPageAdmins.Size = new System.Drawing.Size(1301, 393);
            this.tabPageAdmins.TabIndex = 1;
            this.tabPageAdmins.Text = "Administrators";
            this.tabPageAdmins.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrators";
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(872, 288);
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
            this.btnEditAdmin.Location = new System.Drawing.Point(529, 288);
            this.btnEditAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(285, 39);
            this.btnEditAdmin.TabIndex = 2;
            this.btnEditAdmin.Text = "Edit Admin";
            this.btnEditAdmin.UseVisualStyleBackColor = true;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click_1);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(189, 288);
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
            this.listViewAdmin.Location = new System.Drawing.Point(170, 80);
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
            this.tabPageLects.Controls.Add(this.lblLecturerHeading);
            this.tabPageLects.Controls.Add(this.btnDeleteLect);
            this.tabPageLects.Controls.Add(this.btnEditLect);
            this.tabPageLects.Controls.Add(this.btnAddLect);
            this.tabPageLects.Controls.Add(this.listViewLecturer);
            this.tabPageLects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLects.Location = new System.Drawing.Point(4, 29);
            this.tabPageLects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLects.Name = "tabPageLects";
            this.tabPageLects.Size = new System.Drawing.Size(1301, 393);
            this.tabPageLects.TabIndex = 2;
            this.tabPageLects.Text = "Lecturers";
            this.tabPageLects.UseVisualStyleBackColor = true;
            // 
            // tabPageStuds
            // 
            this.tabPageStuds.Controls.Add(this.label4);
            this.tabPageStuds.Controls.Add(this.button4);
            this.tabPageStuds.Controls.Add(this.button5);
            this.tabPageStuds.Controls.Add(this.button6);
            this.tabPageStuds.Controls.Add(this.listViewStudent);
            this.tabPageStuds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStuds.Location = new System.Drawing.Point(4, 29);
            this.tabPageStuds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStuds.Name = "tabPageStuds";
            this.tabPageStuds.Size = new System.Drawing.Size(1301, 393);
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
            this.lblModuleHeading.Location = new System.Drawing.Point(438, 18);
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
            this.btnEditModule.Click += new System.EventHandler(this.btnEditModule_Click);
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
            // lblLecturerHeading
            // 
            this.lblLecturerHeading.AutoSize = true;
            this.lblLecturerHeading.Location = new System.Drawing.Point(626, 29);
            this.lblLecturerHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerHeading.Name = "lblLecturerHeading";
            this.lblLecturerHeading.Size = new System.Drawing.Size(93, 25);
            this.lblLecturerHeading.TabIndex = 9;
            this.lblLecturerHeading.Text = "Lecturers";
            // 
            // btnDeleteLect
            // 
            this.btnDeleteLect.Location = new System.Drawing.Point(878, 286);
            this.btnDeleteLect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteLect.Name = "btnDeleteLect";
            this.btnDeleteLect.Size = new System.Drawing.Size(285, 39);
            this.btnDeleteLect.TabIndex = 8;
            this.btnDeleteLect.Text = "Delete Lecturer";
            this.btnDeleteLect.UseVisualStyleBackColor = true;
            // 
            // btnEditLect
            // 
            this.btnEditLect.Location = new System.Drawing.Point(535, 286);
            this.btnEditLect.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditLect.Name = "btnEditLect";
            this.btnEditLect.Size = new System.Drawing.Size(285, 39);
            this.btnEditLect.TabIndex = 7;
            this.btnEditLect.Text = "Edit Lecturer";
            this.btnEditLect.UseVisualStyleBackColor = true;
            // 
            // btnAddLect
            // 
            this.btnAddLect.Location = new System.Drawing.Point(195, 286);
            this.btnAddLect.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLect.Name = "btnAddLect";
            this.btnAddLect.Size = new System.Drawing.Size(285, 39);
            this.btnAddLect.TabIndex = 6;
            this.btnAddLect.Text = "Register Lecturer";
            this.btnAddLect.UseVisualStyleBackColor = true;
            this.btnAddLect.Click += new System.EventHandler(this.btnAddLect_Click);
            // 
            // listViewLecturer
            // 
            this.listViewLecturer.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewLecturer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLectID,
            this.columnHeaderLectName,
            this.columnHeaderLectAddress,
            this.columnHeaderLectDOB,
            this.columnHeaderLectPPSN,
            this.columnHeaderLectDateOfHire,
            this.columnHeaderLectModulesToTeach});
            this.listViewLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLecturer.FullRowSelect = true;
            this.listViewLecturer.GridLines = true;
            this.listViewLecturer.HideSelection = false;
            this.listViewLecturer.Location = new System.Drawing.Point(12, 75);
            this.listViewLecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLecturer.MultiSelect = false;
            this.listViewLecturer.Name = "listViewLecturer";
            this.listViewLecturer.Size = new System.Drawing.Size(1276, 176);
            this.listViewLecturer.TabIndex = 5;
            this.listViewLecturer.UseCompatibleStateImageBehavior = false;
            this.listViewLecturer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLectID
            // 
            this.columnHeaderLectID.Text = "Lecturer ID";
            this.columnHeaderLectID.Width = 85;
            // 
            // columnHeaderLectName
            // 
            this.columnHeaderLectName.Text = "Full Name";
            this.columnHeaderLectName.Width = 128;
            // 
            // columnHeaderLectAddress
            // 
            this.columnHeaderLectAddress.Text = "Address";
            this.columnHeaderLectAddress.Width = 116;
            // 
            // columnHeaderLectDOB
            // 
            this.columnHeaderLectDOB.Text = "DOB";
            this.columnHeaderLectDOB.Width = 118;
            // 
            // columnHeaderLectPPSN
            // 
            this.columnHeaderLectPPSN.Text = "PPSN";
            this.columnHeaderLectPPSN.Width = 115;
            // 
            // columnHeaderLectDateOfHire
            // 
            this.columnHeaderLectDateOfHire.Text = "Date Of Hire";
            this.columnHeaderLectDateOfHire.Width = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Administrators";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(870, 288);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete Admin";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(527, 288);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(285, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Edit Admin";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 288);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(285, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add Admin";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listViewStudent
            // 
            this.listViewStudent.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudentID,
            this.columnHeaderStudentName,
            this.columnHeaderStudentAddress,
            this.columnHeaderStudentDOB,
            this.columnHeaderStudentPPSN,
            this.columnHeaderStudentDateEnrolled,
            this.columnHeaderStudentClassGroup});
            this.listViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewStudent.FullRowSelect = true;
            this.listViewStudent.GridLines = true;
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(11, 83);
            this.listViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(1275, 176);
            this.listViewStudent.TabIndex = 5;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStudentID
            // 
            this.columnHeaderStudentID.Text = "Student ID";
            this.columnHeaderStudentID.Width = 85;
            // 
            // columnHeaderStudentName
            // 
            this.columnHeaderStudentName.Text = "Full Name";
            this.columnHeaderStudentName.Width = 163;
            // 
            // columnHeaderStudentAddress
            // 
            this.columnHeaderStudentAddress.Text = "Address";
            this.columnHeaderStudentAddress.Width = 140;
            // 
            // columnHeaderStudentDOB
            // 
            this.columnHeaderStudentDOB.Text = "DOB";
            this.columnHeaderStudentDOB.Width = 118;
            // 
            // columnHeaderStudentPPSN
            // 
            this.columnHeaderStudentPPSN.Text = "PPSN";
            this.columnHeaderStudentPPSN.Width = 115;
            // 
            // columnHeaderStudentDateEnrolled
            // 
            this.columnHeaderStudentDateEnrolled.Text = "Date Enrolled";
            this.columnHeaderStudentDateEnrolled.Width = 127;
            // 
            // columnHeaderLectModulesToTeach
            // 
            this.columnHeaderLectModulesToTeach.Text = "Modules To Teach";
            this.columnHeaderLectModulesToTeach.Width = 166;
            // 
            // columnHeaderStudentClassGroup
            // 
            this.columnHeaderStudentClassGroup.Text = "Class Group";
            this.columnHeaderStudentClassGroup.Width = 140;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorDashboard";
            this.Text = "Administrator Dashboard";
            this.Load += new System.EventHandler(this.AdministratorDashboard_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.grpbModules.ResumeLayout(false);
            this.grpbStuds.ResumeLayout(false);
            this.grpbLects.ResumeLayout(false);
            this.grpbAdmins.ResumeLayout(false);
            this.tabPageAdmins.ResumeLayout(false);
            this.tabPageAdmins.PerformLayout();
            this.tabPageLects.ResumeLayout(false);
            this.tabPageLects.PerformLayout();
            this.tabPageStuds.ResumeLayout(false);
            this.tabPageStuds.PerformLayout();
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
        private System.Windows.Forms.Label lblDashboardHeading;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbModules;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.GroupBox grpbStuds;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.GroupBox grpbLects;
        private System.Windows.Forms.Button btnLect;
        private System.Windows.Forms.GroupBox grpbAdmins;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblLecturerHeading;
        private System.Windows.Forms.Button btnDeleteLect;
        private System.Windows.Forms.Button btnEditLect;
        private System.Windows.Forms.Button btnAddLect;
        private System.Windows.Forms.ListView listViewLecturer;
        private System.Windows.Forms.ColumnHeader columnHeaderLectID;
        private System.Windows.Forms.ColumnHeader columnHeaderLectName;
        private System.Windows.Forms.ColumnHeader columnHeaderLectAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderLectDOB;
        private System.Windows.Forms.ColumnHeader columnHeaderLectPPSN;
        private System.Windows.Forms.ColumnHeader columnHeaderLectDateOfHire;
        private System.Windows.Forms.ColumnHeader columnHeaderLectModulesToTeach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentID;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentName;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentDOB;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentPPSN;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentDateEnrolled;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentClassGroup;
    }
}