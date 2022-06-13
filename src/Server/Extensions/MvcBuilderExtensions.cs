using System.Linq;
using Blazor.CMS.Editor.Application.Configurations;
//using Blazor.CMS.Editor.Application.Features.ExtendedAttributes.Commands.AddEdit;
//using Blazor.CMS.Editor.Application.Validators.Features.ExtendedAttributes.Commands.AddEdit;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.CMS.Editor.Server.Extensions
{
    internal static class MvcBuilderExtensions
    {
        internal static IMvcBuilder AddValidators(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AppConfiguration>());
            return builder;
        }
    }
}