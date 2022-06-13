using Blazor.CMS.Editor.Infrastructure.Models.Identity;
using Blazor.CMS.Editor.Application.Specifications.Base;

namespace Blazor.CMS.Editor.Infrastructure.Specifications
{
    public class UserFilterSpecification : CMSEditorSpecification<CMSEditorUser>
    {
        public UserFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString) || p.Email.Contains(searchString) || p.PhoneNumber.Contains(searchString) || p.UserName.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}