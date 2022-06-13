using Blazor.CMS.Editor.Shared.Settings;
using System.Threading.Tasks;
using Blazor.CMS.Editor.Shared.Wrapper;

namespace Blazor.CMS.Editor.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}