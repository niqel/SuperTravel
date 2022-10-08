using Microsoft.Extensions.DependencyInjection;
using SuperTravel.Application.UseCases.Cases;
using SuperTravel.Core.IUseCases;

namespace SuperTravel.Application.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesContainer(this IServiceCollection service)
        {
            service.AddTransient<IFindAllCountries, CountryFinder>();
            service.AddTransient<ILogIn, Logger>();
            service.AddTransient<ICreateUser, UserCreator>();
            service.AddTransient<IUpdateUser, UserUpdater>();
            return service;

        }
    }
}