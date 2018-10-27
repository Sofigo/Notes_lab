namespace Notes
{
    partial class FormLog
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
            this.username = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.username.Location = new System.Drawing.Point(63, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 17);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(134, 30);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(134, 20);
            this.textUser.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password.Location = new System.Drawing.Point(63, 88);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(68, 17);
            this.password.TabIndex = 2;
            this.password.Text = "password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(134, 88);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(134, 20);
            this.textPassword.TabIndex = 3;
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(134, 144);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(95, 32);
            this.Signup.TabIndex = 4;
            this.Signup.Text = "SignUp";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(261, 144);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 227);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.username);
            this.Name = "FormLog";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Exit;
    }
}