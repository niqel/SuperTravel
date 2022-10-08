using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuperTravel.Core.IRepositories;
using SuperTravel.Infrastructure.EFcoreSqlServer.DataConfiguration;
using SuperTravel.Infrastructure.EFcoreSqlServer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Infrastructure.EFcoreSqlServer
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEFcoreSqlServerContainer(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<SuperTravelDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SuperTravelDbConnection")));
            service.AddTransient<IUserRepository, UserRepository>();
            return service;

        }
    }
}
