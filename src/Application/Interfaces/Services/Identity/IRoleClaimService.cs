using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.CMS.Editor.Application.Interfaces.Common;
using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;

namespace Blazor.CMS.Editor.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}