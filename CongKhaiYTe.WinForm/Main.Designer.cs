
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
            this.pnlChorme.Size = new System.Drawing.Size(1112, 482);
            this.pnlChorme.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 571);
            this.Controls.Add(this.pnlChorme);
            this.Controls.Add(this.btnCrawler);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrawler;
        private System.Windows.Forms.Panel pnlChorme;
    }
}