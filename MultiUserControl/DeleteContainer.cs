using Azure;
using Azure.Storage.Blobs;
using System;
using System.Windows.Forms;

namespace MultiUserControl
{
    public partial class DeleteContainer : UserControl
    {
        private const string connectionString = "Your connection string";
        private BlobServiceClient blobServiceClient;
        private BlobContainerClient blobContainerClient;
        public DeleteContainer()
        {
            InitializeComponent();
            // blobServiceClient = new BlobServiceClient(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string containerName = textBox1.Text;
            try
            {
                blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
                if (blobContainerClient.Exists())
                {
                    blobContainerClient.DeleteIfExists();
                    MessageBox.Show("Container Delted");
                }
                else
                {
                    MessageBox.Show("Conatiner Does not exist");
                }
            }
            catch (RequestFailedException ex)
            {
                MessageBox.Show("Error Deleting blob" + ex.Message);
            }
        }
    }
}
