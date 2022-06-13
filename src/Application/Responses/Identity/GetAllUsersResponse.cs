using System.Collections.Generic;

namespace Blazor.CMS.Editor.Application.Responses.Identity
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}