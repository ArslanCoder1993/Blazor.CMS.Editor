using Blazor.CMS.Editor.Application.Interfaces.Common;
using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}