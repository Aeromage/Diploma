namespace EasyStudy.Shared.Services;

public interface IUploadService
{
    Task<string> UploadFileAsync(Stream file, string fileName, CancellationToken token);

    Task<Stream> GetFileAsync(string filePath, CancellationToken token);
}