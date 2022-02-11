using Microsoft.Extensions.DependencyInjection;
using PROMEDICAL.Business.Services;
using PROMEDICAL.DataAccess;
using PROMEDICAL.Logic.Interfaces;
using PROMEDICAL.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business
{
    public static class ServiceConfiguration
    {
        public static void AddLogicLayer(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<ICargosRepository, CargosRepository>();
            ////https://www.it-swarm.dev/es/c%23/obtencion-de-url-absolutas-utilizando-asp.net-core/1053425403/
            //services.AddSingleton<IActionContextAccessor, ActionContextAccessor>()
            //    .AddScoped<IUrlHelper>(x => x
            //    .GetRequiredService<IUrlHelperFactory>()
            //    .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));

            //AppPromedicalDbContext.ConnectionString();
        }

        public static void AddBusinessLayer(this IServiceCollection services)
        {
            //services.AddAutoMapper(x => x.AddProfile<MappingProfileExtensions>(), AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<CargosService>();
        }
    }
}
