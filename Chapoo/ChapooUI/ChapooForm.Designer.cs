namespace ChapooUI
{
    partial class ChapooForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChapooForm));
            this.ms = new System.Windows.Forms.MenuStrip();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.msName = new System.Windows.Forms.ToolStripMenuItem();
            this.msTime = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.Black;
            this.ms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msExit,
            this.msLogout,
            this.msName,
            this.msTime});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ms.ShowItemToolTips = true;
            this.ms.Size = new System.Drawing.Size(1264, 29);
            this.ms.TabIndex = 3;
            this.ms.Text = "menuStrip1";
            // 
            // msExit
            // 
            this.msExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msExit.ForeColor = System.Drawing.Color.White;
            this.msExit.Image = ((System.Drawing.Image)(resources.GetObject("msExit.Image")));
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(32, 25);
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // msLogout
            // 
            this.msLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msLogout.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLogout.ForeColor = System.Drawing.Color.White;
            this.msLogout.Image = ((System.Drawing.Image)(resources.GetObject("msLogout.Image")));
            this.msLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msLogout.Name = "msLogout";
            this.msLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msLogout.Size = new System.Drawing.Size(32, 25);
            this.msLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msLogout.Click += new System.EventHandler(this.msLogout_Click);
            // 
            // msName
            // 
            this.msName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msName.Enabled = false;
            this.msName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msName.ForeColor = System.Drawing.Color.White;
            this.msName.Name = "msName";
            this.msName.Size = new System.Drawing.Size(101, 25);
            this.msName.Text = "Logged out";
            // 
            // msTime
            // 
            this.msTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msTime.Enabled = false;
            this.msTime.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTime.ForeColor = System.Drawing.Color.White;
            this.msTime.Name = "msTime";
            this.msTime.Size = new System.Drawing.Size(114, 25);
            this.msTime.Text = "Hier komt de tijd";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChapooForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ms);
            this.Name = "ChapooForm";
            this.Text = "Restaurant Chapoo";
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStripMenuItem msLogout;
        private System.Windows.Forms.ToolStripMenuItem msName;
        private System.Windows.Forms.ToolStripMenuItem msTime;
        private System.Windows.Forms.Timer timer1;
    }
}