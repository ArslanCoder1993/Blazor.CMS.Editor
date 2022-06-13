using Blazor.CMS.Editor.Infrastructure.Models.Audit;
using Blazor.CMS.Editor.Application.Specifications.Base;

namespace Blazor.CMS.Editor.Infrastructure.Specifications
{
    public class AuditFilterSpecification : CMSEditorSpecification<CMSTracker>
    {
        public AuditFilterSpecification(string userId, string searchString, bool searchInOldValues, bool searchInNewValues)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => (p.TableName.Contains(searchString) || searchInOldValues && p.OldValues.Contains(searchString) || searchInNewValues && p.NewValues.Contains(searchString)) && p.UserId == userId;
            }
            else
            {
                Criteria = p => p.UserId == userId;
            }
        }
    }
}