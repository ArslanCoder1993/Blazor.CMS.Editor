
using Blazor.CMS.Editor.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace Blazor.CMS.Editor.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}