using Azure.Storage.Blobs;
namespace Training.DevOps.Services
{
    internal class BlobServiceClient
    {
        private string? storageConnectionString;

        public BlobServiceClient( )
        { 
        }

        internal void GetBlobContainerClient()
        {

            string connectionString = Environment.GetEnvironmentVariable("AzureStorage");
            string containerName = "blobcontainer";
            string blobName = "images";
            string filePath = "sample-file";

            // Get a reference to a container named "sample-container" and then create it
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
            container.Create();

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            blob.Upload(filePath);
        }
    }
}