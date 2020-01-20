namespace ChapooUI
{
    partial class pnlTables
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblTitleTable = new System.Windows.Forms.Label();
            this.listViewTables = new System.Windows.Forms.ListView();
            this.tableId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.space = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.free = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.lblTitleTable);
            this.pnlTable.Controls.Add(this.listViewTables);
            this.pnlTable.Location = new System.Drawing.Point(3, 3);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1274, 714);
            this.pnlTable.TabIndex = 5;
            // 
            // lblTitleTable
            // 
            this.lblTitleTable.AutoSize = true;
            this.lblTitleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitleTable.Location = new System.Drawing.Point(485, 0);
            this.lblTitleTable.Name = "lblTitleTable";
            this.lblTitleTable.Size = new System.Drawing.Size(247, 39);
            this.lblTitleTable.TabIndex = 1;
            this.lblTitleTable.Text = "Table overview";
            // 
            // listViewTables
            // 
            this.listViewTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableId,
            this.space,
            this.free});
            this.listViewTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listViewTables.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewTables.Location = new System.Drawing.Point(37, 317);
            this.listViewTables.Name = "listViewTables";
            this.listViewTables.Size = new System.Drawing.Size(1165, 278);
            this.listViewTables.TabIndex = 0;
            this.listViewTables.UseCompatibleStateImageBehavior = false;
            this.listViewTables.View = System.Windows.Forms.View.Details;
            // 
            // tableId
            // 
            this.tableId.Text = "Table number";
            this.tableId.Width = 353;
            // 
            // space
            // 
            this.space.Text = "Space";
            this.space.Width = 329;
            // 
            // free
            // 
            this.free.Text = "Free?";
            this.free.Width = 479;
            // 
            // pnlTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnlTable);
            this.Name = "pnlTables";
            this.Size = new System.Drawing.Size(1280, 720);
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblTitleTable;
        private System.Windows.Forms.ListView listViewTables;
        private System.Windows.Forms.ColumnHeader tableId;
        private System.Windows.Forms.ColumnHeader space;
        private System.Windows.Forms.ColumnHeader free;
    }
}
