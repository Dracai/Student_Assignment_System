
namespace Student_Assignment_System
{
    partial class Form1
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
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.btnLecturerLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Location = new System.Drawing.Point(68, 411);
            this.btnStudentLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(155, 53);
            this.btnStudentLogin.TabIndex = 0;
            this.btnStudentLogin.Text = "Student";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            // 
            // btnLecturerLogin
            // 
            this.btnLecturerLogin.Location = new System.Drawing.Point(448, 411);
            this.btnLecturerLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLecturerLogin.Name = "btnLecturerLogin";
            this.btnLecturerLogin.Size = new System.Drawing.Size(155, 53);
            this.btnLecturerLogin.TabIndex = 1;
            this.btnLecturerLogin.Text = "Lecturer";
            this.btnLecturerLogin.UseVisualStyleBackColor = true;
            this.btnLecturerLogin.Click += new System.EventHandler(this.btnLecturerLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(840, 411);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(155, 53);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "Administrator";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            //this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnLecturerLogin);
            this.Controls.Add(this.btnStudentLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.Button btnLecturerLogin;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}

