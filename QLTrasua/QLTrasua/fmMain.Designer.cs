namespace QLTrasua
{
    partial class fmMain
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTableName = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnCate = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 62;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món gọi";
            this.columnHeader1.Width = 194;
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTableName.Location = new System.Drawing.Point(8, 4);
            this.lbTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(226, 41);
            this.lbTableName.TabIndex = 7;
            this.lbTableName.Text = "Chưa chọn bàn";
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(8, 64);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(707, 422);
            this.lsvBill.TabIndex = 3;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.lbTableName);
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Controls.Add(this.lsvBill);
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Location = new System.Drawing.Point(448, -65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(724, 726);
            this.panel4.TabIndex = 17;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(8, 495);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(711, 81);
            this.txbTotalPrice.TabIndex = 6;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(4, 619);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(712, 97);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Tính tiền";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnCate);
            this.panel3.Controls.Add(this.pnFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(848, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 636);
            this.panel3.TabIndex = 16;
            // 
            // pnCate
            // 
            this.pnCate.AutoScroll = true;
            this.pnCate.BackColor = System.Drawing.Color.SteelBlue;
            this.pnCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnCate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnCate.Location = new System.Drawing.Point(0, 0);
            this.pnCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCate.Name = "pnCate";
            this.pnCate.Size = new System.Drawing.Size(467, 344);
            this.pnCate.TabIndex = 9;
            // 
            // pnFood
            // 
            this.pnFood.AutoScroll = true;
            this.pnFood.BackColor = System.Drawing.Color.SteelBlue;
            this.pnFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFood.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFood.Location = new System.Drawing.Point(0, 352);
            this.pnFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(467, 377);
            this.pnFood.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 636);
            this.panel1.TabIndex = 15;
            // 
            // pnTable
            // 
            this.pnTable.AutoScroll = true;
            this.pnTable.BackColor = System.Drawing.Color.SteelBlue;
            this.pnTable.Location = new System.Drawing.Point(16, 0);
            this.pnTable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(413, 726);
            this.pnTable.TabIndex = 0;
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // cửaHàngToolStripMenuItem
            // 
            this.cửaHàngToolStripMenuItem.Name = "cửaHàngToolStripMenuItem";
            this.cửaHàngToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.cửaHàngToolStripMenuItem.Text = "Cửa hàng";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cửaHàngToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 665);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmMain";
            this.Text = "fmMain";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel pnCate;
        private System.Windows.Forms.FlowLayoutPanel pnFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnTable;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cửaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}