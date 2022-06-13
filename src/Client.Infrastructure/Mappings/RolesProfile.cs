using AutoMapper;
using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;

namespace Blazor.CMS.Editor.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}