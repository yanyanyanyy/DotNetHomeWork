namespace Project
{
    partial class CrawlerForm
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
            this.btnCrawl = new System.Windows.Forms.Button();
            this.StartUrl = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCrawl
            // 
            this.btnCrawl.Location = new System.Drawing.Point(465, 53);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(75, 23);
            this.btnCrawl.TabIndex = 0;
            this.btnCrawl.Text = "开始爬取";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // StartUrl
            // 
            this.StartUrl.Location = new System.Drawing.Point(60, 51);
            this.StartUrl.Name = "StartUrl";
            this.StartUrl.Size = new System.Drawing.Size(349, 25);
            this.StartUrl.TabIndex = 1;
            this.StartUrl.Text = "https://www.cnblogs.com/zzy-tongzhi-cnblog/p/14378551.html";
            this.StartUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(57, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "状态信息";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(60, 171);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(716, 241);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "";
            // 
            // CrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.StartUrl);
            this.Controls.Add(this.btnCrawl);
            this.Name = "CrawlerForm";
            this.Text = "CrawlerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.TextBox StartUrl;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox txtUrl;
    }
}