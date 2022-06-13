using System;
using Blazor.CMS.Editor.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Blazor.CMS.Editor.Infrastructure.Models.Identity
{
    public class CMSEditorClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual CMSEditorRole Role { get; set; }

        public CMSEditorClaim() : base()
        {
        }

        public CMSEditorClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}