using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Business.Services;
using PROMEDICAL.Business.Validations;
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
            services.AddScoped<IAlergiasRepository, AlergiasRepository>();
            services.AddScoped<ICirugiasRepository, CirugiasRepository>();
            services.AddScoped<IPrescripcionesRepository, PrescripcionesRepository>();
            services.AddScoped<ITipoCitasRepository, TipoCitasRepository>();
            services.AddScoped<ITipoConsultasRepository, TipoConsultasRepository>();
            services.AddScoped<ICargosRepository, CargosRepository>();
            services.AddScoped<IConsultoriosRepository, ConsultoriosRepository>();
            services.AddScoped<ITiposSangreRepository, TiposSangreRepository>();
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
            services.AddMvc().AddFluentValidation();
            services.AddTransient<AlergiasValidation> ();
            //services.AddAutoMapper(x => x.AddProfile<MappingProfileExtensions>(), AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<AlergiasService>();
            services.AddScoped<CirugiasService>();
            services.AddScoped<PrescripcionesService>();
            services.AddScoped<TipoCitasService>();
            services.AddScoped<TipoConsultasService>();
            services.AddScoped<CargosService>();
            services.AddScoped<ConsultoriosService>();
            services.AddScoped<TiposSangreService>();
            services.AddScoped<JornadasServices>();
            services.AddScoped<MedicamentosService>();
            services.AddScoped<PesosService>();
            //services.AddScoped<CitasService>();
            services.AddScoped<EmpleadosService>();
            services.AddScoped<EmpresasService>();
            //services.AddScoped<FrecuenciasCardiacasService>();
            //services.AddScoped<PacientesService>();

            /// Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddMoreServices(this IServiceCollection services)
        {

        }
    }
}
