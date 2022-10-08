using Microsoft.Extensions.DependencyInjection;
using SuperTravel.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Infrastructure.UnityOfWork
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUnityOfWorkContainer(this IServiceCollection service)
        {
            service.AddTransient<IUnityOfWork, Unity>();
            return service;
        }
    }
}
