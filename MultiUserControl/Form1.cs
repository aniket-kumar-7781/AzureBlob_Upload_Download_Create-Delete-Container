using Azure.Storage.Blobs;
using System;
using System.Windows.Forms;

namespace MultiUserControl
{
    public partial class Form1 : Form
    {
        private UploadBlob uploadUserControl;
        private DownloadBlob downloadUserControl;
        private DeleteBlob deleteBlobUserControl;
        private DeleteContainer deleteContainerUserControl;
        private BlobServiceClient blobServiceClient;
        public Form1()
        {
            InitializeComponent();

            //string connectionString = "your_connection_string";
            //string containerName = "your_container_name";


            btnUpload.Checked = false;
            btnDownload.Checked = false;
            btnDeleteBlob.Checked = false;
            btnDeleteContainer.Checked = false;
            default1.BringToFront();
            //blobServiceClient = new BlobServiceClient(connectionString);
        }

        private void btnUpload_CheckedChanged(object sender, EventArgs e)
        {
            uploadBlob1.Show();
            uploadBlob1.BringToFront();
            downloadBlob1.Hide();
            deleteBlob1.Hide();
            deleteContainer1.Hide();
        }

        private void btnDownload_CheckedChanged(object sender, EventArgs e)
        {
            uploadBlob1.Hide();
            downloadBlob1.Show();
            downloadBlob1.BringToFront();
            deleteBlob1.Hide();
            deleteContainer1.Hide();
        }

        private void btnDeleteBlob_CheckedChanged(object sender, EventArgs e)
        {
            uploadBlob1.Hide();
            downloadBlob1.Hide();
            deleteBlob1.Show();
            deleteBlob1.BringToFront();
            deleteContainer1.Hide();
        }

        private void btnDeleteContainer_CheckedChanged(object sender, EventArgs e)
        {
            uploadBlob1.Hide();
            downloadBlob1.Hide();
            deleteBlob1.Hide();
            deleteContainer1.Show();
            deleteContainer1.BringToFront();
        }
    }
}
