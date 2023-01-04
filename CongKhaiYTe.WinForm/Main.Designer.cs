
namespace CongKhaiYTe.WinForm
{
    partial class Main
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
            this.btnCrawler = new System.Windows.Forms.Button();
            this.pnlChorme = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnTaxCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrawler
            // 
            this.btnCrawler.Location = new System.Drawing.Point(23, 12);
            this.btnCrawler.Name = "btnCrawler";
            this.btnCrawler.Size = new System.Drawing.Size(75, 23);
            this.btnCrawler.TabIndex = 0;
            this.btnCrawler.Text = "Bóc tách";
            this.btnCrawler.UseVisualStyleBackColor = true;
            this.btnCrawler.Click += new System.EventHandler(this.btnCrawler_Click);
            // 
            // pnlChorme
            // 
            this.pnlChorme.Location = new System.Drawing.Point(13, 59);
            this.pnlChorme.Name = "pnlChorme";
            this.pnlChorme.Size = new System.Drawing.Size(764, 557);
            this.pnlChorme.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(821, 59);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(416, 447);
            this.pnl2.TabIndex = 3;
            // 
            // btnTaxCode
            // 
            this.btnTaxCode.Location = new System.Drawing.Point(131, 11);
            this.btnTaxCode.Name = "btnTaxCode";
            this.btnTaxCode.Size = new System.Drawing.Size(75, 23);
            this.btnTaxCode.TabIndex = 4;
            this.btnTaxCode.Text = "Lấy mã số thuế";
            this.btnTaxCode.UseVisualStyleBackColor = true;
           
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 628);
            this.Controls.Add(this.btnTaxCode);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnlChorme);
            this.Controls.Add(this.btnCrawler);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrawler;
        private System.Windows.Forms.Panel pnlChorme;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnTaxCode;
    }
}