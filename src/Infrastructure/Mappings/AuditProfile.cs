using AutoMapper;
using Blazor.CMS.Editor.Infrastructure.Models.Audit;
using Blazor.CMS.Editor.Application.Responses.Audit;

namespace Blazor.CMS.Editor.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, CMSTracker>().ReverseMap();
        }
    }
}