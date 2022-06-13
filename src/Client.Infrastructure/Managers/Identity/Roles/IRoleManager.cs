using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Identity.Roles
{
    public interface IRoleManager : IManager
    {
        Task<IResult<List<RoleResponse>>> GetRolesAsync();

        Task<IResult<string>> SaveAsync(RoleRequest role);

        Task<IResult<string>> DeleteAsync(string id);

        Task<IResult<PermissionResponse>> GetPermissionsAsync(string roleId);

        Task<IResult<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}