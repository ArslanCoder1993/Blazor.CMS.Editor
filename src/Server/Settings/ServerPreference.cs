using System.Linq;
using Blazor.CMS.Editor.Shared.Constants.Localization;
using Blazor.CMS.Editor.Shared.Settings;

namespace Blazor.CMS.Editor.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}