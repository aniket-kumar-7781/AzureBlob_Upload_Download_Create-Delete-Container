using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace MultiUserControl
{
    public partial class UploadBlob : UserControl
    {
        private const string connectionString = "your_connection_string";
        //string containerName = "your_container_name";
        //blobServiceClient = new BlobServiceClient(connectionString);
        private BlobServiceClient blobServiceClient;
        private BlobContainerClient blobContainerClient;


        public UploadBlob()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = open.FileName;
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string filePath = textBox3.Text;
            string containerName = textBox1.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please Enter a filepath");
                return;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show("The specified file does not exist");
                return;
            }
            try
            {
                string[] xyz = Path.GetFileName(textBox3.Text).Split('.');
                string filePathNew = textBox3.Text.Replace(xyz[0], textBox2.Text);

                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(containerName))
                {
                    blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
                    blobContainerClient.CreateIfNotExists();
                    blobContainerClient.SetAccessPolicy(PublicAccessType.None);
                    string fileName = Path.GetFileName(filePathNew);
                    BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);

                    using (FileStream fileStream = File.OpenRead(filePath))
                    {
                        blobClient.Upload(fileStream, true);
                    }

                    MessageBox.Show("File Uploaded Succesfully");
                }
                else
                {
                    MessageBox.Show("Filename/Container Name cannot be empty");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error occured while uploading the file: {ex.Message}");
            }

        }
    }
}
