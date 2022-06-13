using System;
using System.Collections.Generic;
using Blazor.CMS.Editor.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Blazor.CMS.Editor.Infrastructure.Models.Identity
{
    public class CMSEditorRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<CMSEditorClaim> RoleClaims { get; set; }

        public CMSEditorRole() : base()
        {
            RoleClaims = new HashSet<CMSEditorClaim>();
        }

        public CMSEditorRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<CMSEditorClaim>();
            Description = roleDescription;
        }
    }
}