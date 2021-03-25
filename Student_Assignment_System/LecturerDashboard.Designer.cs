
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
            this.Assignments = new System.Windows.Forms.TabPage();
            this.Logout = new System.Windows.Forms.TabPage();
            this.ClassGroups = new System.Windows.Forms.TabPage();
            this.tcDash.SuspendLayout();
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
            this.tcDash.Size = new System.Drawing.Size(773, 426);
            this.tcDash.TabIndex = 1;
            this.tcDash.SelectedIndexChanged += new System.EventHandler(this.LecLogout);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(4, 29);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(765, 393);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // Assignments
            // 
            this.Assignments.Location = new System.Drawing.Point(4, 29);
            this.Assignments.Name = "Assignments";
            this.Assignments.Padding = new System.Windows.Forms.Padding(3);
            this.Assignments.Size = new System.Drawing.Size(765, 393);
            this.Assignments.TabIndex = 1;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(4, 29);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(3);
            this.Logout.Size = new System.Drawing.Size(765, 393);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // ClassGroups
            // 
            this.ClassGroups.Location = new System.Drawing.Point(4, 29);
            this.ClassGroups.Name = "ClassGroups";
            this.ClassGroups.Padding = new System.Windows.Forms.Padding(3);
            this.ClassGroups.Size = new System.Drawing.Size(765, 393);
            this.ClassGroups.TabIndex = 3;
            this.ClassGroups.Text = "Class Groups";
            this.ClassGroups.UseVisualStyleBackColor = true;
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcDash);
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboard";
            this.tcDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcDash;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.TabPage Assignments;
        private System.Windows.Forms.TabPage Logout;
        private System.Windows.Forms.TabPage ClassGroups;
    }
}