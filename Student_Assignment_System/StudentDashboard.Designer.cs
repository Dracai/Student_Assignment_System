
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
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabStudentDashboard = new System.Windows.Forms.TabPage();
            this.tabStudentAssignments = new System.Windows.Forms.TabPage();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDeadlines = new System.Windows.Forms.ListView();
            this.lblStudentLastname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlStudent.SuspendLayout();
            this.tabStudentDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabStudentDashboard);
            this.tabControlStudent.Controls.Add(this.tabStudentAssignments);
            this.tabControlStudent.Controls.Add(this.tabLogout);
            this.tabControlStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStudent.Location = new System.Drawing.Point(12, 12);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.Padding = new System.Drawing.Point(10, 6);
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(753, 475);
            this.tabControlStudent.TabIndex = 0;
            // 
            // tabStudentDashboard
            // 
            this.tabStudentDashboard.Controls.Add(this.label2);
            this.tabStudentDashboard.Controls.Add(this.textBox1);
            this.tabStudentDashboard.Controls.Add(this.lblStudentLastname);
            this.tabStudentDashboard.Controls.Add(this.lvDeadlines);
            this.tabStudentDashboard.Controls.Add(this.label1);
            this.tabStudentDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStudentDashboard.Location = new System.Drawing.Point(4, 35);
            this.tabStudentDashboard.Name = "tabStudentDashboard";
            this.tabStudentDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentDashboard.Size = new System.Drawing.Size(745, 436);
            this.tabStudentDashboard.TabIndex = 0;
            this.tabStudentDashboard.Text = "Dashboard";
            this.tabStudentDashboard.UseVisualStyleBackColor = true;
            // 
            // tabStudentAssignments
            // 
            this.tabStudentAssignments.Location = new System.Drawing.Point(4, 35);
            this.tabStudentAssignments.Name = "tabStudentAssignments";
            this.tabStudentAssignments.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentAssignments.Size = new System.Drawing.Size(768, 387);
            this.tabStudentAssignments.TabIndex = 1;
            this.tabStudentAssignments.Text = "Assignments";
            this.tabStudentAssignments.UseVisualStyleBackColor = true;
            // 
            // tabLogout
            // 
            this.tabLogout.Location = new System.Drawing.Point(4, 35);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabLogout.Size = new System.Drawing.Size(768, 387);
            this.tabLogout.TabIndex = 2;
            this.tabLogout.Text = "Logout";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, {User}";
            // 
            // lvDeadlines
            // 
            this.lvDeadlines.HideSelection = false;
            this.lvDeadlines.Location = new System.Drawing.Point(523, 62);
            this.lvDeadlines.Name = "lvDeadlines";
            this.lvDeadlines.Size = new System.Drawing.Size(216, 368);
            this.lvDeadlines.TabIndex = 1;
            this.lvDeadlines.UseCompatibleStateImageBehavior = false;
            // 
            // lblStudentLastname
            // 
            this.lblStudentLastname.AutoSize = true;
            this.lblStudentLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLastname.Location = new System.Drawing.Point(60, 140);
            this.lblStudentLastname.Name = "lblStudentLastname";
            this.lblStudentLastname.Size = new System.Drawing.Size(114, 26);
            this.lblStudentLastname.TabIndex = 2;
            this.lblStudentLastname.Text = "Lastname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 499);
            this.Controls.Add(this.tabControlStudent);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.tabControlStudent.ResumeLayout(false);
            this.tabStudentDashboard.ResumeLayout(false);
            this.tabStudentDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabStudentDashboard;
        private System.Windows.Forms.TabPage tabStudentAssignments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStudentLastname;
        private System.Windows.Forms.ListView lvDeadlines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLogout;
    }
}