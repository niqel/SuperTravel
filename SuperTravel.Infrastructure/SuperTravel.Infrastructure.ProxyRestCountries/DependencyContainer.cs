using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using SuperTravel.Core.IRepositories;
using SuperTravel.Infrastructure.ProxyRestCountries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Infrastructure.ProxyRestCountries
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProxyRestCountriesContainer(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddHttpClient("RestCountries", client => 
            {
                client.BaseAddress = new Uri("https://restcountries.com"); 
            });
            service.AddTransient<ICountryRepository, CountryRepository>();
            return service;

        }
    }
}
