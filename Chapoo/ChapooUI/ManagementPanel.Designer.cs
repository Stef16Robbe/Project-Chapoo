namespace ChapooUI
{
    partial class ManagementPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnRegisterShowPassword = new System.Windows.Forms.Button();
            this.cbRegisterType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRegisterKey = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMakeAccount = new System.Windows.Forms.Button();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbRegisterUsername = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(519, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnNewUser.Location = new System.Drawing.Point(524, 128);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(188, 42);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "New user";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegister.Controls.Add(this.btnRegisterShowPassword);
            this.pnlRegister.Controls.Add(this.cbRegisterType);
            this.pnlRegister.Controls.Add(this.label13);
            this.pnlRegister.Controls.Add(this.tbRegisterKey);
            this.pnlRegister.Controls.Add(this.label14);
            this.pnlRegister.Controls.Add(this.btnMakeAccount);
            this.pnlRegister.Controls.Add(this.tbRegisterPassword);
            this.pnlRegister.Controls.Add(this.tbRegisterUsername);
            this.pnlRegister.Controls.Add(this.label21);
            this.pnlRegister.Controls.Add(this.label22);
            this.pnlRegister.Controls.Add(this.label23);
            this.pnlRegister.Location = new System.Drawing.Point(2, 39);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(1134, 567);
            this.pnlRegister.TabIndex = 17;
            // 
            // btnRegisterShowPassword
            // 
            this.btnRegisterShowPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnRegisterShowPassword.Location = new System.Drawing.Point(674, 164);
            this.btnRegisterShowPassword.Name = "btnRegisterShowPassword";
            this.btnRegisterShowPassword.Size = new System.Drawing.Size(122, 25);
            this.btnRegisterShowPassword.TabIndex = 18;
            this.btnRegisterShowPassword.Text = "Show password";
            this.btnRegisterShowPassword.UseVisualStyleBackColor = true;
            this.btnRegisterShowPassword.Click += new System.EventHandler(this.btnRegisterShowPassword_Click);
            // 
            // cbRegisterType
            // 
            this.cbRegisterType.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cbRegisterType.FormattingEnabled = true;
            this.cbRegisterType.Items.AddRange(new object[] {
            "Service",
            "Kitchen",
            "Bar",
            "Check out",
            "Management"});
            this.cbRegisterType.Location = new System.Drawing.Point(528, 199);
            this.cbRegisterType.Margin = new System.Windows.Forms.Padding(2);
            this.cbRegisterType.Name = "cbRegisterType";
            this.cbRegisterType.Size = new System.Drawing.Size(141, 27);
            this.cbRegisterType.TabIndex = 16;
            this.cbRegisterType.Text = "*Choose*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(440, 202);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Register as:";
            // 
            // tbRegisterKey
            // 
            this.tbRegisterKey.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbRegisterKey.Location = new System.Drawing.Point(470, 270);
            this.tbRegisterKey.Margin = new System.Windows.Forms.Padding(2);
            this.tbRegisterKey.Name = "tbRegisterKey";
            this.tbRegisterKey.Size = new System.Drawing.Size(232, 25);
            this.tbRegisterKey.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(467, 249);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "Key:";
            // 
            // btnMakeAccount
            // 
            this.btnMakeAccount.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnMakeAccount.Location = new System.Drawing.Point(528, 303);
            this.btnMakeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeAccount.Name = "btnMakeAccount";
            this.btnMakeAccount.Size = new System.Drawing.Size(128, 29);
            this.btnMakeAccount.TabIndex = 6;
            this.btnMakeAccount.Text = "Make account";
            this.btnMakeAccount.UseVisualStyleBackColor = true;
            this.btnMakeAccount.Click += new System.EventHandler(this.btnMakeAccount_Click_1);
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbRegisterPassword.Location = new System.Drawing.Point(528, 164);
            this.tbRegisterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(141, 25);
            this.tbRegisterPassword.TabIndex = 4;
            // 
            // tbRegisterUsername
            // 
            this.tbRegisterUsername.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbRegisterUsername.Location = new System.Drawing.Point(528, 131);
            this.tbRegisterUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbRegisterUsername.Name = "tbRegisterUsername";
            this.tbRegisterUsername.Size = new System.Drawing.Size(141, 25);
            this.tbRegisterUsername.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(529, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 36);
            this.label21.TabIndex = 2;
            this.label21.Text = "Register";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(449, 167);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Password:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(445, 134);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Username:";
            // 
            // ManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.label1);
            this.Name = "ManagementPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnRegisterShowPassword;
        private System.Windows.Forms.ComboBox cbRegisterType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRegisterKey;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMakeAccount;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.TextBox tbRegisterUsername;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}
