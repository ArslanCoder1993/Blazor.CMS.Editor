using Blazor.CMS.Editor.Application.Responses.Audit;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<IResult<string>> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}