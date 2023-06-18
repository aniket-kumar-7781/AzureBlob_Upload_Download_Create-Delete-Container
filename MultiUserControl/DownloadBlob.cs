using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace MultiUserControl
{
    public partial class DownloadBlob : UserControl
    {
        // private const string connectionString = "Your connection string";
        private BlobServiceClient blobServiceClient;
        private BlobContainerClient blobContainerClient;
        public DownloadBlob()
        {
            InitializeComponent();
            blobList.DropDown += blobList_DropDown;
            // blobServiceClient = new BlobServiceClient(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void blobList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                if (blobList.SelectedItem != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    string selectedBlobName = blobList.SelectedItem.ToString();
                    saveFileDialog.FileName = selectedBlobName;

                    BlobClient blobClient = blobContainerClient.GetBlobClient(selectedBlobName);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string localFilePath = saveFileDialog.FileName;
                        BlobDownloadInfo blobDownloadInfo = blobClient.Download();
                        using (FileStream fileStream = File.OpenWrite(localFilePath))
                        {
                            blobDownloadInfo.Content.CopyTo(fileStream);
                        }
                        MessageBox.Show("File Downloaded");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a blob to download");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blobList_DropDown(object sender, EventArgs e)
        {
            string containerName = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(containerName))
            {
                blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
                if (containerName.Length < 3 || blobContainerClient.Exists() == false)
                {
                    MessageBox.Show("Container does not exist");
                }
                BlobList();
            }
            else
            {
                MessageBox.Show("Container name connot be empty");
                blobList.Items.Clear();
            }
        }

        private void BlobList()
        {
            blobList.Items.Clear();
            try
            {
                if (blobContainerClient != null && blobContainerClient.Exists())
                {
                    var blobs = blobContainerClient.GetBlobs();
                    foreach (BlobItem blob in blobs)
                    {
                        blobList.Items.Add(blob.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured while fetching the blob list");
            }
        }
    }
}
