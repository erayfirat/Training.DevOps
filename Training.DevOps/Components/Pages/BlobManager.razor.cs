using Training.DevOps.Services;


namespace Training.DevOps.Components.Pages
{
    public partial class BlobManager
    {
        private IFormFile file;
        protected override async Task OnInitializedAsync()
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient();

            blobServiceClient.GetBlobContainerClient();
        }
    }
}
