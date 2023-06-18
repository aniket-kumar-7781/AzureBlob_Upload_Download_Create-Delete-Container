using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Windows.Forms;

namespace MultiUserControl
{
    public partial class DeleteBlob : UserControl
    {
        private const string connectionString = "Your connection string";
        private BlobServiceClient blobServiceClient;
        private BlobContainerClient blobContainerClient;
        public DeleteBlob()
        {
            InitializeComponent();
            blobList.DropDown += blobList_DropDown;
            //blobServiceClient = new BlobServiceClient(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void blobList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string seletedBlobName = blobList.SelectedItem.ToString();
                BlobClient blobClient = blobContainerClient.GetBlobClient(seletedBlobName);
                if (blobClient.Exists())
                {
                    blobClient.DeleteIfExists();
                    MessageBox.Show("Blob Deleted");
                }
                else
                {
                    MessageBox.Show("Blob does not exist");
                }
            }
            catch (RequestFailedException ex)
            {
                MessageBox.Show("Error Deleting Blob" + ex.Message);
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
