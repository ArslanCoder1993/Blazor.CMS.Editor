using Blazor.CMS.Editor.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}