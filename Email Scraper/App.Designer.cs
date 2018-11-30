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
            this.buttonStartScraping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURLforScraping
            // 
            this.textBoxURLforScraping.Location = new System.Drawing.Point(173, 68);
            this.textBoxURLforScraping.Name = "textBoxURLforScraping";
            this.textBoxURLforScraping.Size = new System.Drawing.Size(100, 20);
            this.textBoxURLforScraping.TabIndex = 0;
            // 
            // buttonStartScraping
            // 
            this.buttonStartScraping.Location = new System.Drawing.Point(327, 68);
            this.buttonStartScraping.Name = "buttonStartScraping";
            this.buttonStartScraping.Size = new System.Drawing.Size(98, 23);
            this.buttonStartScraping.TabIndex = 1;
            this.buttonStartScraping.Text = "Start Scraping";
            this.buttonStartScraping.UseVisualStyleBackColor = true;
            this.buttonStartScraping.Click += new System.EventHandler(this.buttonStartScraping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartScraping);
            this.Controls.Add(this.textBoxURLforScraping);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURLforScraping;
        private System.Windows.Forms.Button buttonStartScraping;
    }
}

