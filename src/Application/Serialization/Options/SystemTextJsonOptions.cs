using System.Text.Json;
using Blazor.CMS.Editor.Application.Interfaces.Serialization.Options;

namespace Blazor.CMS.Editor.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}