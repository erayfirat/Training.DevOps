
namespace Training.DevOps.Services
{
    internal class BlobServiceClient
    {
        private string? storageConnectionString;

        public BlobServiceClient(string? storageConnectionString)
        {
            this.storageConnectionString = storageConnectionString;
        }

        internal object GetBlobContainerClient(string v)
        {
            throw new NotImplementedException();
        }
    }
}