using EasyStudy.Shared.Services;

namespace EasyStudy.Service.Services;

public class UploadService : IUploadService
{
    public async Task<string> UploadFileAsync(Stream file, string fileName, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task<Stream> GetFileAsync(string filePath, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}