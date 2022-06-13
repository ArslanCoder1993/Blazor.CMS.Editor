using Blazor.CMS.Editor.Shared.Wrapper;
using System.Threading.Tasks;
using Blazor.CMS.Editor.Application.Features.Dashboards.Queries.GetData;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}