namespace QLTrasua
{
    partial class fmChangeMoney
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
            this.btnPrintRecipe = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrintRecipe
            // 
            this.btnPrintRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRecipe.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRecipe.Location = new System.Drawing.Point(427, 167);
            this.btnPrintRecipe.Name = "btnPrintRecipe";
            this.btnPrintRecipe.Size = new System.Drawing.Size(184, 60);
            this.btnPrintRecipe.TabIndex = 7;
            this.btnPrintRecipe.Text = "In hóa đơn";
            this.btnPrintRecipe.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(189, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(184, 60);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Location = new System.Drawing.Point(450, 42);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(13, 13);
            this.lbChange.TabIndex = 5;
            this.lbChange.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiền thừa: ";
            // 
            // fmChangeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.btnPrintRecipe);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.label1);
            this.Name = "fmChangeMoney";
            this.Text = "fmChangeMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintRecipe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label1;
    }
}