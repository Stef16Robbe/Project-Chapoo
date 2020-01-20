namespace ChapooUI
{
    partial class LoginUI
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLoginShowPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnPasswordShowPassword = new System.Windows.Forms.Button();
            this.btnNextStep1 = new System.Windows.Forms.Button();
            this.lblBackToLogin = new System.Windows.Forms.LinkLabel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbWVnewPassword = new System.Windows.Forms.TextBox();
            this.tbWVusername = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.tbWVkey = new System.Windows.Forms.TextBox();
            this.lblkey = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLoginShowPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblForgotPassword);
            this.pnlLogin.Controls.Add(this.tbLoginPassword);
            this.pnlLogin.Controls.Add(this.tbLoginUsername);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Location = new System.Drawing.Point(46, 30);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1132, 589);
            this.pnlLogin.TabIndex = 15;
            // 
            // btnLoginShowPassword
            // 
            this.btnLoginShowPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnLoginShowPassword.Location = new System.Drawing.Point(682, 175);
            this.btnLoginShowPassword.Name = "btnLoginShowPassword";
            this.btnLoginShowPassword.Size = new System.Drawing.Size(129, 25);
            this.btnLoginShowPassword.TabIndex = 19;
            this.btnLoginShowPassword.Text = "Show password";
            this.btnLoginShowPassword.UseVisualStyleBackColor = true;
            this.btnLoginShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(536, 299);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 63);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.LinkColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(544, 221);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(127, 20);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Forgot password?";
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbLoginPassword.Location = new System.Drawing.Point(536, 175);
            this.tbLoginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(141, 25);
            this.tbLoginPassword.TabIndex = 4;
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbLoginUsername.Location = new System.Drawing.Point(536, 137);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(141, 25);
            this.tbLoginUsername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(557, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Log in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(442, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username:";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.lblkey);
            this.pnlPassword.Controls.Add(this.tbWVkey);
            this.pnlPassword.Controls.Add(this.btnPasswordShowPassword);
            this.pnlPassword.Controls.Add(this.btnNextStep1);
            this.pnlPassword.Controls.Add(this.lblBackToLogin);
            this.pnlPassword.Controls.Add(this.btnChangePassword);
            this.pnlPassword.Controls.Add(this.tbWVnewPassword);
            this.pnlPassword.Controls.Add(this.tbWVusername);
            this.pnlPassword.Controls.Add(this.label32);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.label34);
            this.pnlPassword.Location = new System.Drawing.Point(48, 32);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(1132, 585);
            this.pnlPassword.TabIndex = 17;
            // 
            // btnPasswordShowPassword
            // 
            this.btnPasswordShowPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnPasswordShowPassword.Location = new System.Drawing.Point(719, 267);
            this.btnPasswordShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasswordShowPassword.Name = "btnPasswordShowPassword";
            this.btnPasswordShowPassword.Size = new System.Drawing.Size(138, 49);
            this.btnPasswordShowPassword.TabIndex = 9;
            this.btnPasswordShowPassword.Text = "Show password and key";
            this.btnPasswordShowPassword.UseVisualStyleBackColor = true;
            this.btnPasswordShowPassword.Click += new System.EventHandler(this.btnPasswordShowPassword_Click);
            // 
            // btnNextStep1
            // 
            this.btnNextStep1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnNextStep1.Location = new System.Drawing.Point(561, 213);
            this.btnNextStep1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextStep1.Name = "btnNextStep1";
            this.btnNextStep1.Size = new System.Drawing.Size(141, 35);
            this.btnNextStep1.TabIndex = 8;
            this.btnNextStep1.Text = "Next step";
            this.btnNextStep1.UseVisualStyleBackColor = true;
            this.btnNextStep1.Click += new System.EventHandler(this.btnNextStep1_Click_1);
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblBackToLogin.ForeColor = System.Drawing.Color.White;
            this.lblBackToLogin.LinkColor = System.Drawing.Color.White;
            this.lblBackToLogin.Location = new System.Drawing.Point(577, 411);
            this.lblBackToLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(98, 20);
            this.lblBackToLogin.TabIndex = 7;
            this.lblBackToLogin.TabStop = true;
            this.lblBackToLogin.Text = "Back to login";
            this.lblBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBackToLogin_LinkClicked);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnChangePassword.Location = new System.Drawing.Point(561, 334);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(141, 35);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Adjust password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnWijzigWachtwoord_Click_1);
            // 
            // tbWVnewPassword
            // 
            this.tbWVnewPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbWVnewPassword.Location = new System.Drawing.Point(560, 260);
            this.tbWVnewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbWVnewPassword.Name = "tbWVnewPassword";
            this.tbWVnewPassword.Size = new System.Drawing.Size(141, 25);
            this.tbWVnewPassword.TabIndex = 4;
            // 
            // tbWVusername
            // 
            this.tbWVusername.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbWVusername.Location = new System.Drawing.Point(561, 176);
            this.tbWVusername.Margin = new System.Windows.Forms.Padding(2);
            this.tbWVusername.Name = "tbWVusername";
            this.tbWVusername.Size = new System.Drawing.Size(141, 25);
            this.tbWVusername.TabIndex = 3;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(484, 0);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(244, 36);
            this.label32.TabIndex = 2;
            this.label32.Text = "Forgot password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(431, 263);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(109, 20);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New password:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(461, 179);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(79, 20);
            this.label34.TabIndex = 0;
            this.label34.Text = "Username:";
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnCloseLogin.Location = new System.Drawing.Point(1153, 12);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(103, 51);
            this.btnCloseLogin.TabIndex = 18;
            this.btnCloseLogin.Text = "Exit";
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // tbWVkey
            // 
            this.tbWVkey.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbWVkey.Location = new System.Drawing.Point(561, 297);
            this.tbWVkey.Margin = new System.Windows.Forms.Padding(2);
            this.tbWVkey.Name = "tbWVkey";
            this.tbWVkey.Size = new System.Drawing.Size(141, 25);
            this.tbWVkey.TabIndex = 10;
            // 
            // lblkey
            // 
            this.lblkey.AutoSize = true;
            this.lblkey.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblkey.ForeColor = System.Drawing.Color.White;
            this.lblkey.Location = new System.Drawing.Point(504, 300);
            this.lblkey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(36, 20);
            this.lblkey.TabIndex = 11;
            this.lblkey.Text = "Key:";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlLogin);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnNextStep1;
        private System.Windows.Forms.LinkLabel lblBackToLogin;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbWVnewPassword;
        private System.Windows.Forms.TextBox tbWVusername;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnLoginShowPassword;
        private System.Windows.Forms.Button btnPasswordShowPassword;
        private System.Windows.Forms.Label lblkey;
        private System.Windows.Forms.TextBox tbWVkey;
    }
}