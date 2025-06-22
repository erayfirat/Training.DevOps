using Training.DevOps.Services;


namespace Training.DevOps.Components.Pages
{
    public partial class BlobManager
    {
        private IFormFile file;
        protected override async Task OnInitializedAsync()
        {
            var storageConnectionString = Environment.GetEnvironmentVariable("AzureStorageConnectionString");
            var blobServiceClient = new BlobServiceClient(storageConnectionString);
            var containerClient = blobServiceClient.GetBlobContainerClient("images");

            using var stream = file.OpenReadStream(); // file is IFormFile
            //await containerClient.UploadBlobAsync(file.FileName, stream);

        }
    }
}
