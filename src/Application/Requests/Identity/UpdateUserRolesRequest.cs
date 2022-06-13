using Blazor.CMS.Editor.Application.Responses.Identity;
using System.Collections.Generic;

namespace Blazor.CMS.Editor.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}