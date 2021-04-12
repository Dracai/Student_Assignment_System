namespace Student_Assignment_System
{
    partial class StudentDashboard
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
            this.tcStudentDash = new System.Windows.Forms.TabControl();
            this.tbStudentDashboard = new System.Windows.Forms.TabPage();
            this.txtStudentAssignmentNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentClassgroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxDeadlines = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentWelcome = new System.Windows.Forms.Label();
            this.tpStudentAssignments = new System.Windows.Forms.TabPage();
            this.btnAComplete = new System.Windows.Forms.Button();
            this.txtSADesciption = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSALecturer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSADateDue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSAName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSAModuleID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvStudentAssignments = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpStudentLogout = new System.Windows.Forms.TabPage();
            this.tcStudentDash.SuspendLayout();
            this.tbStudentDashboard.SuspendLayout();
            this.tpStudentAssignments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStudentDash
            // 
            this.tcStudentDash.Controls.Add(this.tbStudentDashboard);
            this.tcStudentDash.Controls.Add(this.tpStudentAssignments);
            this.tcStudentDash.Controls.Add(this.tpStudentLogout);
            this.tcStudentDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudentDash.Location = new System.Drawing.Point(12, 12);
            this.tcStudentDash.Name = "tcStudentDash";
            this.tcStudentDash.SelectedIndex = 0;
            this.tcStudentDash.Size = new System.Drawing.Size(776, 426);
            this.tcStudentDash.TabIndex = 0;
            this.tcStudentDash.SelectedIndexChanged += new System.EventHandler(this.StudentFormIndexChange);
            // 
            // tbStudentDashboard
            // 
            this.tbStudentDashboard.Controls.Add(this.txtStudentAssignmentNum);
            this.tbStudentDashboard.Controls.Add(this.label5);
            this.tbStudentDashboard.Controls.Add(this.txtStudentClassgroup);
            this.tbStudentDashboard.Controls.Add(this.label4);
            this.tbStudentDashboard.Controls.Add(this.txtStudentCourse);
            this.tbStudentDashboard.Controls.Add(this.label3);
            this.tbStudentDashboard.Controls.Add(this.lboxDeadlines);
            this.tbStudentDashboard.Controls.Add(this.label1);
            this.tbStudentDashboard.Controls.Add(this.lblStudentWelcome);
            this.tbStudentDashboard.Location = new System.Drawing.Point(4, 29);
            this.tbStudentDashboard.Name = "tbStudentDashboard";
            this.tbStudentDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDashboard.Size = new System.Drawing.Size(768, 393);
            this.tbStudentDashboard.TabIndex = 0;
            this.tbStudentDashboard.Text = "Dashboard";
            this.tbStudentDashboard.UseVisualStyleBackColor = true;
            // 
            // txtStudentAssignmentNum
            // 
            this.txtStudentAssignmentNum.Location = new System.Drawing.Point(250, 209);
            this.txtStudentAssignmentNum.Name = "txtStudentAssignmentNum";
            this.txtStudentAssignmentNum.Size = new System.Drawing.Size(189, 26);
            this.txtStudentAssignmentNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "No. of Assignments:";
            // 
            // txtStudentClassgroup
            // 
            this.txtStudentClassgroup.Location = new System.Drawing.Point(250, 167);
            this.txtStudentClassgroup.Name = "txtStudentClassgroup";
            this.txtStudentClassgroup.Size = new System.Drawing.Size(189, 26);
            this.txtStudentClassgroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Classgroup:";
            // 
            // txtStudentCourse
            // 
            this.txtStudentCourse.Location = new System.Drawing.Point(250, 127);
            this.txtStudentCourse.Name = "txtStudentCourse";
            this.txtStudentCourse.Size = new System.Drawing.Size(189, 26);
            this.txtStudentCourse.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course:";
            // 
            // lboxDeadlines
            // 
            this.lboxDeadlines.FormattingEnabled = true;
            this.lboxDeadlines.ItemHeight = 20;
            this.lboxDeadlines.Location = new System.Drawing.Point(545, 82);
            this.lboxDeadlines.Name = "lboxDeadlines";
            this.lboxDeadlines.Size = new System.Drawing.Size(217, 304);
            this.lboxDeadlines.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deadlines";
            // 
            // lblStudentWelcome
            // 
            this.lblStudentWelcome.AutoSize = true;
            this.lblStudentWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentWelcome.Location = new System.Drawing.Point(35, 21);
            this.lblStudentWelcome.Name = "lblStudentWelcome";
            this.lblStudentWelcome.Size = new System.Drawing.Size(238, 31);
            this.lblStudentWelcome.TabIndex = 0;
            this.lblStudentWelcome.Text = "Welcome, { User } ";
            // 
            // tpStudentAssignments
            // 
            this.tpStudentAssignments.Controls.Add(this.btnAComplete);
            this.tpStudentAssignments.Controls.Add(this.txtSADesciption);
            this.tpStudentAssignments.Controls.Add(this.label10);
            this.tpStudentAssignments.Controls.Add(this.txtSALecturer);
            this.tpStudentAssignments.Controls.Add(this.label9);
            this.tpStudentAssignments.Controls.Add(this.txtSADateDue);
            this.tpStudentAssignments.Controls.Add(this.label8);
            this.tpStudentAssignments.Controls.Add(this.txtSAName);
            this.tpStudentAssignments.Controls.Add(this.label7);
            this.tpStudentAssignments.Controls.Add(this.txtSAModuleID);
            this.tpStudentAssignments.Controls.Add(this.label6);
            this.tpStudentAssignments.Controls.Add(this.lvStudentAssignments);
            this.tpStudentAssignments.Location = new System.Drawing.Point(4, 29);
            this.tpStudentAssignments.Name = "tpStudentAssignments";
            this.tpStudentAssignments.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentAssignments.Size = new System.Drawing.Size(768, 393);
            this.tpStudentAssignments.TabIndex = 1;
            this.tpStudentAssignments.Text = "Assignments";
            this.tpStudentAssignments.UseVisualStyleBackColor = true;
            // 
            // btnAComplete
            // 
            this.btnAComplete.Location = new System.Drawing.Point(418, 344);
            this.btnAComplete.Name = "btnAComplete";
            this.btnAComplete.Size = new System.Drawing.Size(95, 32);
            this.btnAComplete.TabIndex = 11;
            this.btnAComplete.Text = "Complete";
            this.btnAComplete.UseVisualStyleBackColor = true;
            this.btnAComplete.Click += new System.EventHandler(this.btnAComplete_Click);
            // 
            // txtSADesciption
            // 
            this.txtSADesciption.Location = new System.Drawing.Point(563, 258);
            this.txtSADesciption.Multiline = true;
            this.txtSADesciption.Name = "txtSADesciption";
            this.txtSADesciption.Size = new System.Drawing.Size(199, 118);
            this.txtSADesciption.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Description :";
            // 
            // txtSALecturer
            // 
            this.txtSALecturer.Location = new System.Drawing.Point(563, 203);
            this.txtSALecturer.Name = "txtSALecturer";
            this.txtSALecturer.Size = new System.Drawing.Size(199, 26);
            this.txtSALecturer.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lecturer :";
            // 
            // txtSADateDue
            // 
            this.txtSADateDue.Location = new System.Drawing.Point(562, 150);
            this.txtSADateDue.Name = "txtSADateDue";
            this.txtSADateDue.Size = new System.Drawing.Size(200, 26);
            this.txtSADateDue.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date Due :";
            // 
            // txtSAName
            // 
            this.txtSAName.Location = new System.Drawing.Point(563, 98);
            this.txtSAName.Name = "txtSAName";
            this.txtSAName.Size = new System.Drawing.Size(199, 26);
            this.txtSAName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name :";
            // 
            // txtSAModuleID
            // 
            this.txtSAModuleID.Location = new System.Drawing.Point(562, 43);
            this.txtSAModuleID.Name = "txtSAModuleID";
            this.txtSAModuleID.Size = new System.Drawing.Size(200, 26);
            this.txtSAModuleID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Module :";
            // 
            // lvStudentAssignments
            // 
            this.lvStudentAssignments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chModule,
            this.chName});
            this.lvStudentAssignments.GridLines = true;
            this.lvStudentAssignments.HideSelection = false;
            this.lvStudentAssignments.Location = new System.Drawing.Point(6, 18);
            this.lvStudentAssignments.Name = "lvStudentAssignments";
            this.lvStudentAssignments.Size = new System.Drawing.Size(406, 358);
            this.lvStudentAssignments.TabIndex = 0;
            this.lvStudentAssignments.UseCompatibleStateImageBehavior = false;
            this.lvStudentAssignments.View = System.Windows.Forms.View.Details;
            this.lvStudentAssignments.SelectedIndexChanged += new System.EventHandler(this.lvStudentAssignments_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 100;
            // 
            // chModule
            // 
            this.chModule.Text = "Module";
            this.chModule.Width = 150;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // tpStudentLogout
            // 
            this.tpStudentLogout.Location = new System.Drawing.Point(4, 29);
            this.tpStudentLogout.Name = "tpStudentLogout";
            this.tpStudentLogout.Size = new System.Drawing.Size(768, 393);
            this.tpStudentLogout.TabIndex = 2;
            this.tpStudentLogout.Text = "Logout";
            this.tpStudentLogout.UseVisualStyleBackColor = true;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcStudentDash);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.tcStudentDash.ResumeLayout(false);
            this.tbStudentDashboard.ResumeLayout(false);
            this.tbStudentDashboard.PerformLayout();
            this.tpStudentAssignments.ResumeLayout(false);
            this.tpStudentAssignments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStudentDash;
        private System.Windows.Forms.TabPage tbStudentDashboard;
        private System.Windows.Forms.TabPage tpStudentAssignments;
        private System.Windows.Forms.TextBox txtStudentAssignmentNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentClassgroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxDeadlines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentWelcome;
        private System.Windows.Forms.Button btnAComplete;
        private System.Windows.Forms.TextBox txtSADesciption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSALecturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSADateDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSAName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSAModuleID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvStudentAssignments;
        private System.Windows.Forms.ColumnHeader chModule;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.TabPage tpStudentLogout;
        private System.Windows.Forms.ColumnHeader chID;
    }
}