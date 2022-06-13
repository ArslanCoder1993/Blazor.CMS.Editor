using Blazor.CMS.Editor.Application.Interfaces.Services;
using System;

namespace Blazor.CMS.Editor.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}