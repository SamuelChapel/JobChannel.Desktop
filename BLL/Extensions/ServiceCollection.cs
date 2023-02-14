using BLL.Http;
using BLL.Services.Contracts;
using BLL.Services.Geographic;
using BLL.Services.JobOffers;
using BLL.Services.Jobs;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddHttpClient<IJobChannelHttpClient, JobChannelHttpClient>();
        services.AddScoped<IJobOfferService, JobOfferService>();
        services.AddScoped<IGeoService, GeoService>();
        services.AddScoped<IContractService, ContractService>();
        services.AddScoped<IJobService, JobService>();

        return services;
    }
}
