using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Blazor.CMS.Editor.Application.Interfaces.Repositories;
using Blazor.CMS.Editor.Application.Interfaces.Services.Storage;
using Blazor.CMS.Editor.Application.Interfaces.Services.Storage.Provider;
using Blazor.CMS.Editor.Application.Interfaces.Serialization.Serializers;
using Blazor.CMS.Editor.Application.Serialization.JsonConverters;
using Blazor.CMS.Editor.Infrastructure.Repositories;
using Blazor.CMS.Editor.Infrastructure.Services.Storage;
using Blazor.CMS.Editor.Application.Serialization.Options;
using Blazor.CMS.Editor.Infrastructure.Services.Storage.Provider;
using Blazor.CMS.Editor.Application.Serialization.Serializers;

namespace Blazor.CMS.Editor.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IRepositoryAsync<,>), typeof(RepositoryAsync<,>))
                .AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }
        public static IServiceCollection AddServerStorage(this IServiceCollection services)
            => AddServerStorage(services, null);

        public static IServiceCollection AddServerStorage(this IServiceCollection services, Action<SystemTextJsonOptions> configure)
        {
            return services
                .AddScoped<IJsonSerializer, SystemTextJsonSerializer>()
                .AddScoped<IStorageProvider, ServerStorageProvider>()
                .AddScoped<IServerStorageService, ServerStorageService>()
                .AddScoped<ISyncServerStorageService, ServerStorageService>()
                .Configure<SystemTextJsonOptions>(configureOptions =>
                {
                    configure?.Invoke(configureOptions);
                    if (!configureOptions.JsonSerializerOptions.Converters.Any(c => c.GetType() == typeof(TimespanJsonConverter)))
                        configureOptions.JsonSerializerOptions.Converters.Add(new TimespanJsonConverter());
                });
        }
    }
}