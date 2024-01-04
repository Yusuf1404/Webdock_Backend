using Microsoft.Extensions.DependencyInjection;
using Webdock.Factory;
using Webdock.Models.Configuration;
using Webdock.Services;
using Webdock.Services.Account;
using Webdock.Services.Snapshot;
using Webdock.Services.Snapshot;

namespace Webdock.Extensions;

public static class WebdockServiceCollectionExtension
{
    public static IServiceCollection AddWebdock(this IServiceCollection services,
        Action<WebdockConnectionConfiguration> configurationSetter)
    {
        // Set the webdock configuration
        var configuration = new WebdockConnectionConfiguration();
        configurationSetter(configuration);
        services.AddSingleton<WebdockConnectionConfiguration>(configuration);

        // Connection Factory
        services.AddSingleton<WebdockHttpClientFactory>();

        // Services and endpoints
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<ISnapshotService, SnapshotService>();
        services.AddScoped<IPingService, PingService>();

        return services;
    }
}