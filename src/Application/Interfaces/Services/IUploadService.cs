using Blazor.CMS.Editor.Application.Requests;

namespace Blazor.CMS.Editor.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}