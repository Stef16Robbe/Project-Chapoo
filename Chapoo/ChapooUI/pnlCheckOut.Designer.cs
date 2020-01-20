namespace ChapooUI
{
    partial class pnlCheckOut
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
            this.lbl_CheckOut = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Table = new System.Windows.Forms.Label();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_BillInvullen = new System.Windows.Forms.Label();
            this.lbl_TotalInvullen = new System.Windows.Forms.Label();
            this.txtbox_Tip = new System.Windows.Forms.TextBox();
            this.bttn_Pin = new System.Windows.Forms.Button();
            this.bttn_Cash = new System.Windows.Forms.Button();
            this.btnBackToOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_VATinvullen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CheckOut
            // 
            this.lbl_CheckOut.AutoSize = true;
            this.lbl_CheckOut.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckOut.ForeColor = System.Drawing.Color.White;
            this.lbl_CheckOut.Location = new System.Drawing.Point(536, 31);
            this.lbl_CheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CheckOut.Name = "lbl_CheckOut";
            this.lbl_CheckOut.Size = new System.Drawing.Size(155, 36);
            this.lbl_CheckOut.TabIndex = 3;
            this.lbl_CheckOut.Text = "Check Out";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity,
            this.Naam,
            this.Price,
            this.Total});
            this.listViewOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrder.Location = new System.Drawing.Point(23, 142);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(568, 429);
            this.listViewOrder.TabIndex = 4;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 66;
            // 
            // Naam
            // 
            this.Naam.Name = "pnlCheckOut";
            this.Naam.Text = "Name";
            this.Naam.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Total
            // 
            this.Total.Text = "Total price";
            this.Total.Width = 77;
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Table.ForeColor = System.Drawing.Color.White;
            this.lbl_Table.Location = new System.Drawing.Point(148, 114);
            this.lbl_Table.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(210, 25);
            this.lbl_Table.TabIndex = 5;
            this.lbl_Table.Text = "Order Table (number)";
            // 
            // lbl_bill
            // 
            this.lbl_bill.AutoSize = true;
            this.lbl_bill.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill.ForeColor = System.Drawing.Color.White;
            this.lbl_bill.Location = new System.Drawing.Point(653, 140);
            this.lbl_bill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(60, 35);
            this.lbl_bill.TabIndex = 6;
            this.lbl_bill.Text = "Bill:";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tip.ForeColor = System.Drawing.Color.White;
            this.lbl_Tip.Location = new System.Drawing.Point(652, 252);
            this.lbl_Tip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(61, 35);
            this.lbl_Tip.TabIndex = 7;
            this.lbl_Tip.Text = "Tip:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(625, 308);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(86, 35);
            this.lbl_Total.TabIndex = 8;
            this.lbl_Total.Text = "Total:";
            // 
            // lbl_BillInvullen
            // 
            this.lbl_BillInvullen.AutoSize = true;
            this.lbl_BillInvullen.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillInvullen.ForeColor = System.Drawing.Color.White;
            this.lbl_BillInvullen.Location = new System.Drawing.Point(841, 140);
            this.lbl_BillInvullen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BillInvullen.Name = "lbl_BillInvullen";
            this.lbl_BillInvullen.Size = new System.Drawing.Size(181, 35);
            this.lbl_BillInvullen.TabIndex = 9;
            this.lbl_BillInvullen.Text = "Bill (Invullen)";
            // 
            // lbl_TotalInvullen
            // 
            this.lbl_TotalInvullen.AutoSize = true;
            this.lbl_TotalInvullen.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalInvullen.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalInvullen.Location = new System.Drawing.Point(841, 308);
            this.lbl_TotalInvullen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalInvullen.Name = "lbl_TotalInvullen";
            this.lbl_TotalInvullen.Size = new System.Drawing.Size(207, 35);
            this.lbl_TotalInvullen.TabIndex = 10;
            this.lbl_TotalInvullen.Text = "Total (Invullen)";
            // 
            // txtbox_Tip
            // 
            this.txtbox_Tip.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Tip.Location = new System.Drawing.Point(847, 249);
            this.txtbox_Tip.Name = "txtbox_Tip";
            this.txtbox_Tip.Size = new System.Drawing.Size(192, 43);
            this.txtbox_Tip.TabIndex = 11;
            this.txtbox_Tip.TextChanged += new System.EventHandler(this.txtbox_Tip_TextChanged);
            // 
            // bttn_Pin
            // 
            this.bttn_Pin.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.bttn_Pin.Location = new System.Drawing.Point(631, 509);
            this.bttn_Pin.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_Pin.Name = "bttn_Pin";
            this.bttn_Pin.Size = new System.Drawing.Size(189, 62);
            this.bttn_Pin.TabIndex = 12;
            this.bttn_Pin.Text = "Pin";
            this.bttn_Pin.UseVisualStyleBackColor = true;
            this.bttn_Pin.Click += new System.EventHandler(this.bttn_Pin_Click);
            // 
            // bttn_Cash
            // 
            this.bttn_Cash.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.bttn_Cash.Location = new System.Drawing.Point(847, 509);
            this.bttn_Cash.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_Cash.Name = "bttn_Cash";
            this.bttn_Cash.Size = new System.Drawing.Size(189, 62);
            this.bttn_Cash.TabIndex = 13;
            this.bttn_Cash.Text = "Cash";
            this.bttn_Cash.UseVisualStyleBackColor = true;
            this.bttn_Cash.Click += new System.EventHandler(this.bttn_Cash_Click);
            // 
            // btnBackToOrders
            // 
            this.btnBackToOrders.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.btnBackToOrders.Location = new System.Drawing.Point(631, 420);
            this.btnBackToOrders.Name = "btnBackToOrders";
            this.btnBackToOrders.Size = new System.Drawing.Size(405, 62);
            this.btnBackToOrders.TabIndex = 14;
            this.btnBackToOrders.Text = "Back to table";
            this.btnBackToOrders.UseVisualStyleBackColor = true;
            this.btnBackToOrders.Click += new System.EventHandler(this.btnBackToOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "VAT:";
            // 
            // lbl_VATinvullen
            // 
            this.lbl_VATinvullen.AutoSize = true;
            this.lbl_VATinvullen.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VATinvullen.ForeColor = System.Drawing.Color.White;
            this.lbl_VATinvullen.Location = new System.Drawing.Point(841, 196);
            this.lbl_VATinvullen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VATinvullen.Name = "lbl_VATinvullen";
            this.lbl_VATinvullen.Size = new System.Drawing.Size(195, 35);
            this.lbl_VATinvullen.TabIndex = 16;
            this.lbl_VATinvullen.Text = "VAT (Invullen)";
            // 
            // pnlCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lbl_VATinvullen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToOrders);
            this.Controls.Add(this.bttn_Cash);
            this.Controls.Add(this.bttn_Pin);
            this.Controls.Add(this.txtbox_Tip);
            this.Controls.Add(this.lbl_TotalInvullen);
            this.Controls.Add(this.lbl_BillInvullen);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.lbl_bill);
            this.Controls.Add(this.lbl_Table);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.lbl_CheckOut);
            this.Name = "pnlCheckOut";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CheckOut;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Label lbl_Table;
        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_BillInvullen;
        private System.Windows.Forms.Label lbl_TotalInvullen;
        private System.Windows.Forms.TextBox txtbox_Tip;
        private System.Windows.Forms.Button bttn_Pin;
        private System.Windows.Forms.Button bttn_Cash;
        private System.Windows.Forms.Button btnBackToOrders;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_VATinvullen;
    }
}
