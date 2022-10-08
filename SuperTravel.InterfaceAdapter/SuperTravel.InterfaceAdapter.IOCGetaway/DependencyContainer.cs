using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperTravel.Application.UseCases;
using SuperTravel.Infrastructure.EFcoreSqlServer;
using SuperTravel.Infrastructure.ProxyRestCountries;
using SuperTravel.Infrastructure.UnityOfWork;

namespace SuperTravel.InterfaceAdapter.IOCGetaway
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddSuperTravelDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUseCasesContainer();
            services.AddEFcoreSqlServerContainer(configuration);
            services.AddProxyRestCountriesContainer(configuration);
            services.AddUnityOfWorkContainer();
            return services;
        }
    }
}