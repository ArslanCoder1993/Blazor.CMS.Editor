using Blazor.CMS.Editor.Application.Interfaces.Common;

namespace Blazor.CMS.Editor.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}