using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Identity.Authentication
{
    public interface IAuthenticationManager : IManager
    {
        Task<IResult> Login(TokenRequest model);

        Task<IResult> Logout();

        Task<string> RefreshToken();

        Task<string> TryRefreshToken();

        Task<string> TryForceRefreshToken();

        Task<ClaimsPrincipal> CurrentUser();
    }
}