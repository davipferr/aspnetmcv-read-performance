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
using System.Data.Entity;

namespace QueryPerformance
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<SqlServerDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<DbContext, SqlServerDbContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IGenericRepository<OneThousandRows>, GenericRepository<OneThousandRows>>();

            container.RegisterType<IRowsService, RowsService>();
            container.RegisterType<IRowsAppService, RowsAppService>();

            container.RegisterType<Controllers.RowsController>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
