namespace Email_Scraper
{
    partial class App
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
            this.textBoxURLforScraping = new System.Windows.Forms.TextBox();
            this.buttonCreateSitemap = new System.Windows.Forms.Button();
            this.richTextBoxSitemap = new System.Windows.Forms.RichTextBox();
            this.labelURLforScraping = new System.Windows.Forms.Label();
            this.labelSitemap = new System.Windows.Forms.Label();
            this.buttonStartScraping = new System.Windows.Forms.Button();
            this.richTextBoxEmailAddresses = new System.Windows.Forms.RichTextBox();
            this.labelEmailAddresses = new System.Windows.Forms.Label();
            this.buttonSaveAFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURLforScraping
            // 
            this.textBoxURLforScraping.Location = new System.Drawing.Point(54, 6);
            this.textBoxURLforScraping.Name = "textBoxURLforScraping";
            this.textBoxURLforScraping.Size = new System.Drawing.Size(163, 20);
            this.textBoxURLforScraping.TabIndex = 0;
            // 
            // buttonCreateSitemap
            // 
            this.buttonCreateSitemap.Location = new System.Drawing.Point(223, 4);
            this.buttonCreateSitemap.Name = "buttonCreateSitemap";
            this.buttonCreateSitemap.Size = new System.Drawing.Size(98, 23);
            this.buttonCreateSitemap.TabIndex = 1;
            this.buttonCreateSitemap.Text = "Create Sitemap";
            this.buttonCreateSitemap.UseVisualStyleBackColor = true;
            this.buttonCreateSitemap.Click += new System.EventHandler(this.buttonStartScraping_Click);
            // 
            // richTextBoxSitemap
            // 
            this.richTextBoxSitemap.Location = new System.Drawing.Point(15, 74);
            this.richTextBoxSitemap.Name = "richTextBoxSitemap";
            this.richTextBoxSitemap.Size = new System.Drawing.Size(306, 96);
            this.richTextBoxSitemap.TabIndex = 2;
            this.richTextBoxSitemap.Text = "";
            this.richTextBoxSitemap.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelURLforScraping
            // 
            this.labelURLforScraping.AutoSize = true;
            this.labelURLforScraping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelURLforScraping.Location = new System.Drawing.Point(12, 9);
            this.labelURLforScraping.Name = "labelURLforScraping";
            this.labelURLforScraping.Size = new System.Drawing.Size(36, 13);
            this.labelURLforScraping.TabIndex = 3;
            this.labelURLforScraping.Text = "URL:";
            // 
            // labelSitemap
            // 
            this.labelSitemap.AutoSize = true;
            this.labelSitemap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSitemap.Location = new System.Drawing.Point(12, 58);
            this.labelSitemap.Name = "labelSitemap";
            this.labelSitemap.Size = new System.Drawing.Size(52, 13);
            this.labelSitemap.TabIndex = 4;
            this.labelSitemap.Text = "Sitemap";
            // 
            // buttonStartScraping
            // 
            this.buttonStartScraping.Location = new System.Drawing.Point(223, 176);
            this.buttonStartScraping.Name = "buttonStartScraping";
            this.buttonStartScraping.Size = new System.Drawing.Size(98, 23);
            this.buttonStartScraping.TabIndex = 5;
            this.buttonStartScraping.Text = "Start Scraping";
            this.buttonStartScraping.UseVisualStyleBackColor = true;
            // 
            // richTextBoxEmailAddresses
            // 
            this.richTextBoxEmailAddresses.Location = new System.Drawing.Point(15, 258);
            this.richTextBoxEmailAddresses.Name = "richTextBoxEmailAddresses";
            this.richTextBoxEmailAddresses.Size = new System.Drawing.Size(306, 146);
            this.richTextBoxEmailAddresses.TabIndex = 6;
            this.richTextBoxEmailAddresses.Text = "";
            // 
            // labelEmailAddresses
            // 
            this.labelEmailAddresses.AutoSize = true;
            this.labelEmailAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmailAddresses.Location = new System.Drawing.Point(12, 242);
            this.labelEmailAddresses.Name = "labelEmailAddresses";
            this.labelEmailAddresses.Size = new System.Drawing.Size(99, 13);
            this.labelEmailAddresses.TabIndex = 7;
            this.labelEmailAddresses.Text = "Email Addresses";
            this.labelEmailAddresses.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSaveAFile
            // 
            this.buttonSaveAFile.Location = new System.Drawing.Point(223, 410);
            this.buttonSaveAFile.Name = "buttonSaveAFile";
            this.buttonSaveAFile.Size = new System.Drawing.Size(98, 23);
            this.buttonSaveAFile.TabIndex = 8;
            this.buttonSaveAFile.Text = "Save a File";
            this.buttonSaveAFile.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.buttonSaveAFile);
            this.Controls.Add(this.labelEmailAddresses);
            this.Controls.Add(this.richTextBoxEmailAddresses);
            this.Controls.Add(this.buttonStartScraping);
            this.Controls.Add(this.labelSitemap);
            this.Controls.Add(this.labelURLforScraping);
            this.Controls.Add(this.richTextBoxSitemap);
            this.Controls.Add(this.buttonCreateSitemap);
            this.Controls.Add(this.textBoxURLforScraping);
            this.Name = "App";
            this.Text = "Email Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURLforScraping;
        private System.Windows.Forms.Button buttonCreateSitemap;
        private System.Windows.Forms.RichTextBox richTextBoxSitemap;
        private System.Windows.Forms.Label labelURLforScraping;
        private System.Windows.Forms.Label labelSitemap;
        private System.Windows.Forms.Button buttonStartScraping;
        private System.Windows.Forms.RichTextBox richTextBoxEmailAddresses;
        private System.Windows.Forms.Label labelEmailAddresses;
        private System.Windows.Forms.Button buttonSaveAFile;
    }
}

