using Blazor.CMS.Editor.Application.Enums;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.CMS.Editor.Infrastructure.Models.Audit
{
    public class CMSTrackerEntry
    {
        public CMSTrackerEntry(EntityEntry entry)
        {
            Entry = entry;
        }

        public EntityEntry Entry { get; }
        public string UserId { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; } = new();
        public Dictionary<string, object> OldValues { get; } = new();
        public Dictionary<string, object> NewValues { get; } = new();
        public List<PropertyEntry> TemporaryProperties { get; } = new();
        public AuditType AuditType { get; set; }
        public List<string> ChangedColumns { get; } = new();
        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public CMSTracker ToAudit()
        {
            var audit = new CMSTracker
            {
                UserId = UserId,
                Type = AuditType.ToString(),
                TableName = TableName,
                DateTime = DateTime.UtcNow,
                PrimaryKey = JsonConvert.SerializeObject(KeyValues),
                OldValues = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues),
                NewValues = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues),
                AffectedColumns = ChangedColumns.Count == 0 ? null : JsonConvert.SerializeObject(ChangedColumns)
            };
            return audit;
        }
    }
}