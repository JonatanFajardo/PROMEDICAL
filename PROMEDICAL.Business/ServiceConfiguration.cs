using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using PROMEDICAL.Business.Services;
using PROMEDICAL.DataAccess;
using PROMEDICAL.Logic.Interfaces.Especific;
using PROMEDICAL.Logic.Interfaces.General;
using PROMEDICAL.Logic.Repositories;
using PROMEDICAL.Logic.Repositories.General;
using System;

namespace PROMEDICAL.Business
{
    public static class ServiceConfiguration
    {
        public static void AddLogicLayer(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IPrescripcionesRepository, PrescripcionesRepository>();
            services.AddScoped<ITipoCitasRepository, TipoCitasRepository>();
            services.AddScoped<ITipoConsultasRepository, TipoConsultasRepository>();
            services.AddScoped<ICargosRepository, CargosRepository>();
            services.AddScoped<IConsultoriosRepository, ConsultoriosRepository>();
            services.AddScoped<IEspecialidadesRepository, EspecialidadesRepository>();
            services.AddScoped<IJornadasRepository, JornadasRepository>();
            services.AddScoped<IMedicamentosRepository, MedicamentosRepository>();
            services.AddScoped<IPesosRepository, PesosRepository>();
            services.AddScoped<ICitasRepository, CitasRepository>();
            services.AddScoped<IEmpleadosRepository, EmpleadosRepository>();
            services.AddScoped<IEmpresasRepository, EmpresasRepository>();
            services.AddScoped<IFrecuenciasCardiacasRepository, FrecuenciasCardiacasRepository>();
            services.AddScoped<IPacientesRepository, PacientesRepository>();
            services.AddScoped<IPersonasRepository, PersonasRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();





            ////https://www.it-swarm.dev/es/c%23/obtencion-de-url-absolutas-utilizando-asp.net-core/1053425403/
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>()
                .AddScoped<IUrlHelper>(x => x
                .GetRequiredService<IUrlHelperFactory>()
                .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));

            AppPromedicalDbContext.BuildConnectionString(connectionString);
        }

        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile<MappingProfile>(), AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<PrescripcionesService>();
            services.AddScoped<TipoCitasService>();
            services.AddScoped<TipoConsultasService>();
            services.AddScoped<CargosService>();
            services.AddScoped<ConsultoriosService>();
            services.AddScoped<EspecialidadesService>();
            //services.AddScoped<JornadasService>();
            services.AddScoped<MedicamentosService>();
            services.AddScoped<PesosService>();
            //services.AddScoped<CitasService>();
            //services.AddScoped<EmpleadosService>();
            //services.AddScoped<EmpresasService>();
            //services.AddScoped<FrecuenciasCardiacasService>();
            //services.AddScoped<PacientesService>();
            //services.AddScoped<PersonasService>();
        }

        public static void AddMoreServices(this IServiceCollection services)
        {

        }
    }
}
