namespace MultiUserControl
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteContainer = new System.Windows.Forms.RadioButton();
            this.btnDeleteBlob = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.RadioButton();
            this.btnUpload = new System.Windows.Forms.RadioButton();
            this.uploadBlob1 = new MultiUserControl.UploadBlob();
            this.downloadBlob1 = new MultiUserControl.DownloadBlob();
            this.deleteContainer1 = new MultiUserControl.DeleteContainer();
            this.deleteBlob1 = new MultiUserControl.DeleteBlob();
            this.default1 = new MultiUserControl.Default();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteContainer);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteBlob);
            this.splitContainer1.Panel1.Controls.Add(this.btnDownload);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpload);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.default1);
            this.splitContainer1.Panel2.Controls.Add(this.uploadBlob1);
            this.splitContainer1.Panel2.Controls.Add(this.downloadBlob1);
            this.splitContainer1.Panel2.Controls.Add(this.deleteContainer1);
            this.splitContainer1.Panel2.Controls.Add(this.deleteBlob1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteContainer
            // 
            this.btnDeleteContainer.AutoSize = true;
            this.btnDeleteContainer.Location = new System.Drawing.Point(28, 262);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(128, 20);
            this.btnDeleteContainer.TabIndex = 3;
            this.btnDeleteContainer.TabStop = true;
            this.btnDeleteContainer.Text = "Delete Container";
            this.btnDeleteContainer.UseVisualStyleBackColor = true;
            this.btnDeleteContainer.CheckedChanged += new System.EventHandler(this.btnDeleteContainer_CheckedChanged);
            // 
            // btnDeleteBlob
            // 
            this.btnDeleteBlob.AutoSize = true;
            this.btnDeleteBlob.Location = new System.Drawing.Point(28, 216);
            this.btnDeleteBlob.Name = "btnDeleteBlob";
            this.btnDeleteBlob.Size = new System.Drawing.Size(99, 20);
            this.btnDeleteBlob.TabIndex = 2;
            this.btnDeleteBlob.Text = "Delete Blob";
            this.btnDeleteBlob.UseVisualStyleBackColor = true;
            this.btnDeleteBlob.CheckedChanged += new System.EventHandler(this.btnDeleteBlob_CheckedChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.Location = new System.Drawing.Point(28, 164);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 20);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.CheckedChanged += new System.EventHandler(this.btnDownload_CheckedChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.Checked = true;
            this.btnUpload.Location = new System.Drawing.Point(28, 118);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(104, 20);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.TabStop = true;
            this.btnUpload.Text = "Upload Blob";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.CheckedChanged += new System.EventHandler(this.btnUpload_CheckedChanged);
            // 
            // uploadBlob1
            // 
            this.uploadBlob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadBlob1.Location = new System.Drawing.Point(0, 0);
            this.uploadBlob1.Name = "uploadBlob1";
            this.uploadBlob1.Size = new System.Drawing.Size(634, 450);
            this.uploadBlob1.TabIndex = 3;
            // 
            // downloadBlob1
            // 
            this.downloadBlob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadBlob1.Location = new System.Drawing.Point(0, 0);
            this.downloadBlob1.Name = "downloadBlob1";
            this.downloadBlob1.Size = new System.Drawing.Size(634, 450);
            this.downloadBlob1.TabIndex = 2;
            // 
            // deleteContainer1
            // 
            this.deleteContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteContainer1.Location = new System.Drawing.Point(0, 0);
            this.deleteContainer1.Name = "deleteContainer1";
            this.deleteContainer1.Size = new System.Drawing.Size(634, 450);
            this.deleteContainer1.TabIndex = 1;
            // 
            // deleteBlob1
            // 
            this.deleteBlob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBlob1.Location = new System.Drawing.Point(0, 0);
            this.deleteBlob1.Name = "deleteBlob1";
            this.deleteBlob1.Size = new System.Drawing.Size(634, 450);
            this.deleteBlob1.TabIndex = 0;
            // 
            // default1
            // 
            this.default1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.default1.Location = new System.Drawing.Point(0, 0);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(634, 450);
            this.default1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton btnDeleteContainer;
        private System.Windows.Forms.RadioButton btnDeleteBlob;
        private System.Windows.Forms.RadioButton btnDownload;
        private System.Windows.Forms.RadioButton btnUpload;
        private DeleteBlob deleteBlob1;
        private UploadBlob uploadBlob1;
        private DownloadBlob downloadBlob1;
        private DeleteContainer deleteContainer1;
        private Default default1;
    }
}

