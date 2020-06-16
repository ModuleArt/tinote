using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace quick_sticky_notes
{
	public class GSyncManager
	{
        private DriveService service;
        private UserCredential credential;
        private string clientId = "61270361354-mq6q5kspjelmnmjcdceq678m5f2fepv4.apps.googleusercontent.com";
        private string clientSecret = "CbXRaHlFmz_UvU2ndW4xyOKz";

        public GSyncManager()
        {

        }

        public bool IsAuthorized()
        {
            return service != null;
        }

        public void Authorize()
        {
            string[] scopes = new string[] { DriveService.Scope.Drive, DriveService.Scope.DriveFile };
           
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync
            (
                new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                },
                scopes,
                Environment.UserName, 
                CancellationToken.None, 
                new FileDataStore("Quick Sticky Notes")
            ).Result;

            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Quick Sticky Notes"
            });
        }

        public void Unauthorize()
        {
            GoogleWebAuthorizationBroker.ReauthorizeAsync(credential, CancellationToken.None);
        }

        public async Task Upload() 
        {
            await Task.Factory.StartNew(() => 
            {
                try
                {
                    var responce = UploadFileToDrive("QuickStickyNotes.json", "QuickStickyNotes.json", "text/plain");
                    if (responce != null)
                    {
                        OnSyncDone(EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        }

        protected virtual void OnSyncDone(EventArgs e)
        {
            SyncDone?.Invoke(this, e);
        }
        public event EventHandler<EventArgs> SyncDone;

        private string UploadFileToDrive(string fileName, string filePath, string contentType)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = fileName;

            string query = "mimeType!='application/vnd.google-apps.folder' and trashed = false and name = '" + fileName + "'";
            FilesResource.ListRequest req;
            req = service.Files.List();
            req.Q = query;
            req.Fields = "files(id, name)";
            var result = req.Execute();

            if (result.Files.Count == 1)
            {
                FilesResource.UpdateMediaUpload updateRequest;
                string fileId = result.Files[0].Id;

                using (var stream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    updateRequest = service.Files.Update(fileMetadata, fileId, stream, contentType);
                    updateRequest.Upload();
                    var file = updateRequest.ResponseBody;
                    return file.Id;
                };
            }
            else
            {
                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, contentType);
                    request.Fields = "id";
                    request.Upload();
                    var file = request.ResponseBody;
                    return file.Id;
                };
            }
        }
    }
}
