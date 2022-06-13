using AutoMapper;
using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;
using Blazor.CMS.Editor.Infrastructure.Models.Identity;

namespace Blazor.CMS.Editor.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, CMSEditorClaim>()
                .ForMember(nameof(CMSEditorClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(CMSEditorClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, CMSEditorClaim>()
                .ForMember(nameof(CMSEditorClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(CMSEditorClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}