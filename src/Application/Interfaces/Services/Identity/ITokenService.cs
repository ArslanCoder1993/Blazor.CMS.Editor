using Blazor.CMS.Editor.Application.Interfaces.Common;
using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}