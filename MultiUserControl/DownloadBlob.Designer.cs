namespace MultiUserControl
{
    partial class DownloadBlob
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blobList = new System.Windows.Forms.ComboBox();
            this.Download = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Container Name";
            // 
            // blobList
            // 
            this.blobList.FormattingEnabled = true;
            this.blobList.Location = new System.Drawing.Point(277, 208);
            this.blobList.Name = "blobList";
            this.blobList.Size = new System.Drawing.Size(210, 24);
            this.blobList.TabIndex = 5;
            this.blobList.SelectedIndexChanged += new System.EventHandler(this.blobList_SelectedIndexChanged);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(277, 320);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(99, 23);
            this.Download.TabIndex = 6;
            this.Download.Text = "Dowmload";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Blob";
            // 
            // DownloadBlob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.blobList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DownloadBlob";
            this.Size = new System.Drawing.Size(816, 582);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox blobList;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label label2;
    }
}
