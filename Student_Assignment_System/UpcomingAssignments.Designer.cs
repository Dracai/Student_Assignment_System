
namespace Student_Assignment_System
{
    partial class UpcomingAssignments
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
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.lblCg = new System.Windows.Forms.Label();
            this.lvUpcomingAssignment = new System.Windows.Forms.ListView();
            this.AssignName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignModule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewDescription = new System.Windows.Forms.Button();
            this.AssignID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcoming.Location = new System.Drawing.Point(124, 33);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(241, 24);
            this.lblUpcoming.TabIndex = 0;
            this.lblUpcoming.Text = "Upcoming Assingments for ";
            // 
            // lblCg
            // 
            this.lblCg.AutoSize = true;
            this.lblCg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCg.Location = new System.Drawing.Point(360, 36);
            this.lblCg.Name = "lblCg";
            this.lblCg.Size = new System.Drawing.Size(51, 20);
            this.lblCg.TabIndex = 1;
            this.lblCg.Text = "label1";
            // 
            // lvUpcomingAssignment
            // 
            this.lvUpcomingAssignment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AssignID,
            this.AssignName,
            this.AssignModule,
            this.AssignDue});
            this.lvUpcomingAssignment.GridLines = true;
            this.lvUpcomingAssignment.HideSelection = false;
            this.lvUpcomingAssignment.Location = new System.Drawing.Point(12, 74);
            this.lvUpcomingAssignment.MultiSelect = false;
            this.lvUpcomingAssignment.Name = "lvUpcomingAssignment";
            this.lvUpcomingAssignment.Size = new System.Drawing.Size(524, 354);
            this.lvUpcomingAssignment.TabIndex = 2;
            this.lvUpcomingAssignment.UseCompatibleStateImageBehavior = false;
            this.lvUpcomingAssignment.View = System.Windows.Forms.View.Details;
            // 
            // AssignName
            // 
            this.AssignName.DisplayIndex = 0;
            this.AssignName.Text = "Assignment Name";
            this.AssignName.Width = 186;
            // 
            // AssignDue
            // 
            this.AssignDue.DisplayIndex = 1;
            this.AssignDue.Text = "Due Date";
            this.AssignDue.Width = 95;
            // 
            // AssignModule
            // 
            this.AssignModule.Text = "Module";
            this.AssignModule.Width = 228;
            // 
            // btnViewDescription
            // 
            this.btnViewDescription.Location = new System.Drawing.Point(202, 434);
            this.btnViewDescription.Name = "btnViewDescription";
            this.btnViewDescription.Size = new System.Drawing.Size(145, 31);
            this.btnViewDescription.TabIndex = 3;
            this.btnViewDescription.Text = "View Description";
            this.btnViewDescription.UseVisualStyleBackColor = true;
            this.btnViewDescription.Click += new System.EventHandler(this.btnViewDescription_Click);
            // 
            // AssignID
            // 
            this.AssignID.Text = "ID";
            this.AssignID.Width = 0;
            // 
            // UpcomingAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 477);
            this.Controls.Add(this.btnViewDescription);
            this.Controls.Add(this.lvUpcomingAssignment);
            this.Controls.Add(this.lblCg);
            this.Controls.Add(this.lblUpcoming);
            this.Name = "UpcomingAssignments";
            this.Text = "UpcomingAssignments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.Label lblCg;
        private System.Windows.Forms.ListView lvUpcomingAssignment;
        private System.Windows.Forms.ColumnHeader AssignName;
        private System.Windows.Forms.ColumnHeader AssignModule;
        private System.Windows.Forms.ColumnHeader AssignDue;
        private System.Windows.Forms.Button btnViewDescription;
        private System.Windows.Forms.ColumnHeader AssignID;
    }
}