using AutoMapper;
using Blazor.CMS.Editor.Infrastructure.Models.Identity;
using Blazor.CMS.Editor.Application.Responses.Identity;

namespace Blazor.CMS.Editor.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, CMSEditorUser>().ReverseMap()
                .ForMember(dest => dest.Email, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}