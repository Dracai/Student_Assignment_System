
namespace Student_Assignment_System
{
    partial class LecturerDashboard
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
            this.tcDash = new System.Windows.Forms.TabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnClassGroupsGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLectName = new System.Windows.Forms.Label();
            this.txtwelcomemessage = new System.Windows.Forms.Label();
            this.gbassignments = new System.Windows.Forms.GroupBox();
            this.btnAssignmentsGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Assignments = new System.Windows.Forms.TabPage();
            this.btnRemoveAssignment = new System.Windows.Forms.Button();
            this.btnEditAssignment = new System.Windows.Forms.Button();
            this.btnCreateAssignment = new System.Windows.Forms.Button();
            this.lvAssignmentsAss = new System.Windows.Forms.ListView();
            this.AssignmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignmentModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAssignmentsCG = new System.Windows.Forms.ListView();
            this.ClassGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearofStudy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassGroups = new System.Windows.Forms.TabPage();
            this.lvClassGroupsCG = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logout = new System.Windows.Forms.TabPage();
            this.tcDash.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.gb.SuspendLayout();
            this.gbassignments.SuspendLayout();
            this.Assignments.SuspendLayout();
            this.ClassGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDash
            // 
            this.tcDash.Controls.Add(this.Dashboard);
            this.tcDash.Controls.Add(this.Assignments);
            this.tcDash.Controls.Add(this.ClassGroups);
            this.tcDash.Controls.Add(this.Logout);
            this.tcDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDash.Location = new System.Drawing.Point(15, 12);
            this.tcDash.Name = "tcDash";
            this.tcDash.SelectedIndex = 0;
            this.tcDash.Size = new System.Drawing.Size(1113, 482);
            this.tcDash.TabIndex = 1;
            this.tcDash.SelectedIndexChanged += new System.EventHandler(this.LecLogout);
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.gb);
            this.Dashboard.Controls.Add(this.txtLectName);
            this.Dashboard.Controls.Add(this.txtwelcomemessage);
            this.Dashboard.Controls.Add(this.gbassignments);
            this.Dashboard.Location = new System.Drawing.Point(4, 29);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(1105, 449);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnClassGroupsGo);
            this.gb.Controls.Add(this.label2);
            this.gb.Location = new System.Drawing.Point(576, 123);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(440, 257);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "Class Groups";
            // 
            // btnClassGroupsGo
            // 
            this.btnClassGroupsGo.Location = new System.Drawing.Point(181, 165);
            this.btnClassGroupsGo.Name = "btnClassGroupsGo";
            this.btnClassGroupsGo.Size = new System.Drawing.Size(89, 40);
            this.btnClassGroupsGo.TabIndex = 2;
            this.btnClassGroupsGo.Text = "Go";
            this.btnClassGroupsGo.UseVisualStyleBackColor = true;
            this.btnClassGroupsGo.Click += new System.EventHandler(this.btnClassGroupsGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Class Groups, Students\r\nand See Upcoming Assignments \r\nfor Class Groups";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLectName
            // 
            this.txtLectName.AutoSize = true;
            this.txtLectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectName.Location = new System.Drawing.Point(609, 42);
            this.txtLectName.Name = "txtLectName";
            this.txtLectName.Size = new System.Drawing.Size(124, 37);
            this.txtLectName.TabIndex = 2;
            this.txtLectName.Text = "{ User }";
            // 
            // txtwelcomemessage
            // 
            this.txtwelcomemessage.AutoSize = true;
            this.txtwelcomemessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcomemessage.Location = new System.Drawing.Point(364, 42);
            this.txtwelcomemessage.Name = "txtwelcomemessage";
            this.txtwelcomemessage.Size = new System.Drawing.Size(239, 37);
            this.txtwelcomemessage.TabIndex = 1;
            this.txtwelcomemessage.Text = "Welcome Back ";
            // 
            // gbassignments
            // 
            this.gbassignments.Controls.Add(this.btnAssignmentsGo);
            this.gbassignments.Controls.Add(this.label1);
            this.gbassignments.Location = new System.Drawing.Point(92, 123);
            this.gbassignments.Name = "gbassignments";
            this.gbassignments.Size = new System.Drawing.Size(423, 257);
            this.gbassignments.TabIndex = 0;
            this.gbassignments.TabStop = false;
            this.gbassignments.Text = "Assignments";
            // 
            // btnAssignmentsGo
            // 
            this.btnAssignmentsGo.Location = new System.Drawing.Point(153, 165);
            this.btnAssignmentsGo.Name = "btnAssignmentsGo";
            this.btnAssignmentsGo.Size = new System.Drawing.Size(88, 40);
            this.btnAssignmentsGo.TabIndex = 1;
            this.btnAssignmentsGo.Text = "Go";
            this.btnAssignmentsGo.UseVisualStyleBackColor = true;
            this.btnAssignmentsGo.Click += new System.EventHandler(this.btnAssignmentsGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mange, View and Create \r\nNew Assignments For Class Groups \r\nto Complete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignments
            // 
            this.Assignments.Controls.Add(this.btnRemoveAssignment);
            this.Assignments.Controls.Add(this.btnEditAssignment);
            this.Assignments.Controls.Add(this.btnCreateAssignment);
            this.Assignments.Controls.Add(this.lvAssignmentsAss);
            this.Assignments.Controls.Add(this.lvAssignmentsCG);
            this.Assignments.Location = new System.Drawing.Point(4, 29);
            this.Assignments.Name = "Assignments";
            this.Assignments.Padding = new System.Windows.Forms.Padding(3);
            this.Assignments.Size = new System.Drawing.Size(1105, 449);
            this.Assignments.TabIndex = 1;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAssignment
            // 
            this.btnRemoveAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAssignment.Location = new System.Drawing.Point(420, 370);
            this.btnRemoveAssignment.Name = "btnRemoveAssignment";
            this.btnRemoveAssignment.Size = new System.Drawing.Size(153, 34);
            this.btnRemoveAssignment.TabIndex = 4;
            this.btnRemoveAssignment.Text = "Remove Assignment";
            this.btnRemoveAssignment.UseVisualStyleBackColor = true;
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAssignment.Location = new System.Drawing.Point(882, 370);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(153, 34);
            this.btnEditAssignment.TabIndex = 3;
            this.btnEditAssignment.Text = "Edit Assignment";
            this.btnEditAssignment.UseVisualStyleBackColor = true;
            // 
            // btnCreateAssignment
            // 
            this.btnCreateAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAssignment.Location = new System.Drawing.Point(116, 370);
            this.btnCreateAssignment.Name = "btnCreateAssignment";
            this.btnCreateAssignment.Size = new System.Drawing.Size(140, 34);
            this.btnCreateAssignment.TabIndex = 2;
            this.btnCreateAssignment.Text = "Create Assignment";
            this.btnCreateAssignment.UseVisualStyleBackColor = true;
            // 
            // lvAssignmentsAss
            // 
            this.lvAssignmentsAss.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AssignmentID,
            this.AssignmentName,
            this.DueDate,
            this.AssignmentModule});
            this.lvAssignmentsAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAssignmentsAss.FullRowSelect = true;
            this.lvAssignmentsAss.GridLines = true;
            this.lvAssignmentsAss.HideSelection = false;
            this.lvAssignmentsAss.Location = new System.Drawing.Point(384, 24);
            this.lvAssignmentsAss.MultiSelect = false;
            this.lvAssignmentsAss.Name = "lvAssignmentsAss";
            this.lvAssignmentsAss.Size = new System.Drawing.Size(691, 309);
            this.lvAssignmentsAss.TabIndex = 1;
            this.lvAssignmentsAss.UseCompatibleStateImageBehavior = false;
            this.lvAssignmentsAss.View = System.Windows.Forms.View.Details;
            // 
            // AssignmentID
            // 
            this.AssignmentID.Width = 0;
            // 
            // AssignmentName
            // 
            this.AssignmentName.Text = "Assignment";
            this.AssignmentName.Width = 82;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Date Due";
            this.DueDate.Width = 95;
            // 
            // AssignmentModule
            // 
            this.AssignmentModule.Text = "Module";
            this.AssignmentModule.Width = 510;
            // 
            // lvAssignmentsCG
            // 
            this.lvAssignmentsCG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassGroupName,
            this.Course,
            this.YearofStudy,
            this.ClassSize});
            this.lvAssignmentsCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAssignmentsCG.FullRowSelect = true;
            this.lvAssignmentsCG.GridLines = true;
            this.lvAssignmentsCG.HideSelection = false;
            this.lvAssignmentsCG.Location = new System.Drawing.Point(34, 24);
            this.lvAssignmentsCG.MultiSelect = false;
            this.lvAssignmentsCG.Name = "lvAssignmentsCG";
            this.lvAssignmentsCG.Size = new System.Drawing.Size(326, 309);
            this.lvAssignmentsCG.TabIndex = 0;
            this.lvAssignmentsCG.UseCompatibleStateImageBehavior = false;
            this.lvAssignmentsCG.View = System.Windows.Forms.View.Details;
            // 
            // ClassGroupName
            // 
            this.ClassGroupName.Text = "Class Group";
            this.ClassGroupName.Width = 91;
            // 
            // Course
            // 
            this.Course.Text = "Course";
            this.Course.Width = 150;
            // 
            // YearofStudy
            // 
            this.YearofStudy.Text = "Year";
            this.YearofStudy.Width = 43;
            // 
            // ClassSize
            // 
            this.ClassSize.Text = "Size";
            this.ClassSize.Width = 38;
            // 
            // ClassGroups
            // 
            this.ClassGroups.Controls.Add(this.lvClassGroupsCG);
            this.ClassGroups.Location = new System.Drawing.Point(4, 29);
            this.ClassGroups.Name = "ClassGroups";
            this.ClassGroups.Padding = new System.Windows.Forms.Padding(3);
            this.ClassGroups.Size = new System.Drawing.Size(1105, 449);
            this.ClassGroups.TabIndex = 3;
            this.ClassGroups.Text = "Class Groups";
            this.ClassGroups.UseVisualStyleBackColor = true;
            // 
            // lvClassGroupsCG
            // 
            this.lvClassGroupsCG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvClassGroupsCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClassGroupsCG.FullRowSelect = true;
            this.lvClassGroupsCG.GridLines = true;
            this.lvClassGroupsCG.HideSelection = false;
            this.lvClassGroupsCG.Location = new System.Drawing.Point(32, 21);
            this.lvClassGroupsCG.MultiSelect = false;
            this.lvClassGroupsCG.Name = "lvClassGroupsCG";
            this.lvClassGroupsCG.Size = new System.Drawing.Size(326, 309);
            this.lvClassGroupsCG.TabIndex = 1;
            this.lvClassGroupsCG.UseCompatibleStateImageBehavior = false;
            this.lvClassGroupsCG.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Class Group";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            this.columnHeader3.Width = 43;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            this.columnHeader4.Width = 38;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(4, 29);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(3);
            this.Logout.Size = new System.Drawing.Size(1105, 449);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 526);
            this.Controls.Add(this.tcDash);
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboard";
            this.tcDash.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.gbassignments.ResumeLayout(false);
            this.gbassignments.PerformLayout();
            this.Assignments.ResumeLayout(false);
            this.ClassGroups.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcDash;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Assignments;
        private System.Windows.Forms.TabPage Logout;
        private System.Windows.Forms.TabPage ClassGroups;
        private System.Windows.Forms.Label txtwelcomemessage;
        private System.Windows.Forms.GroupBox gbassignments;
        private System.Windows.Forms.Label txtLectName;
        private System.Windows.Forms.Button btnAssignmentsGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnClassGroupsGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAssignmentsCG;
        private System.Windows.Forms.ColumnHeader ClassGroupName;
        private System.Windows.Forms.ColumnHeader Course;
        private System.Windows.Forms.ColumnHeader YearofStudy;
        private System.Windows.Forms.ColumnHeader ClassSize;
        private System.Windows.Forms.ListView lvAssignmentsAss;
        private System.Windows.Forms.ColumnHeader AssignmentName;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader AssignmentModule;
        private System.Windows.Forms.Button btnEditAssignment;
        private System.Windows.Forms.Button btnCreateAssignment;
        private System.Windows.Forms.Button btnRemoveAssignment;
        private System.Windows.Forms.ListView lvClassGroupsCG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader AssignmentID;
    }
}