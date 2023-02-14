using JobChannelDesktop.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace JobChannelDesktop.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<FormMain>();
        services.AddTransient<FormJobChannel>();
        services.AddTransient<FormJobOffer>();

        return services;
    }
}
