using Blazor.CMS.Editor.Application.Responses.Audit;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}