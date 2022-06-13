using AutoMapper;
using Blazor.CMS.Editor.Infrastructure.Models.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;

namespace Blazor.CMS.Editor.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, CMSEditorRole>().ReverseMap();
        }
    }
}