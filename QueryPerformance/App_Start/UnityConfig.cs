using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Unity.Lifetime;
using QueryPerformance.Data;
using QueryPerformance.Repositories.Interfaces;
using QueryPerformance.Repositories.Implementations;
using QueryPerformance.Models;
using QueryPerformance.Services.Interfaces;
using QueryPerformance.Services.Implementations;
using QueryPerformance.AppServices.Interfaces;
using QueryPerformance.AppServices.Implementations;

namespace QueryPerformance
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register DbContext
            container.RegisterType<SqlServerDbContext>(new HierarchicalLifetimeManager());

            // Register Repositories
            container.RegisterType<IGenericRepository<OneThousandRows>, GenericRepository<OneThousandRows>>();

            // Register Domain Services
            container.RegisterType<IRowsService, RowsService>();

            // Register Application Services
            container.RegisterType<IRowsAppService, RowsAppService>();

            // Register Controllers
            container.RegisterType<Controllers.RowsController>();

            // Set the dependency resolver
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
