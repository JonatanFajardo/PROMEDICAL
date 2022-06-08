using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PROMEDICAL.Business;
using PROMEDICAL.WebApi.Swagger;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PROMEDICAL.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation();
            services.AddControllers();
            services.AddLogicLayer(Configuration.GetConnectionString("MEDICALSYSTEM"));
            services.AddValidatorServices();
            services.AddBusinessLayer();



            /*Inicio configuración Swagger*/
            services.AddVersionedApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'VVV";

                // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                // can also be used to control the format of the API version in route templates
                opt.SubstituteApiVersionInUrl = true;
            });

            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new UrlSegmentApiVersionReader();
            });
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerOptions>();
            services.AddSwaggerGen(opt =>
            {
                opt.ExampleFilters();


                opt.EnableAnnotations();
                var xmlPath = GetXmlDataAnnotationFilePath();
                if (!string.IsNullOrEmpty(xmlPath))
                {
                    opt.IncludeXmlComments(xmlPath);
                }

                //opt.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                //{
                //    Description = "Authorization header. Example: \"bearer {token}\"",
                //    In = ParameterLocation.Header,
                //    Name = "authorization",
                //    Type = SecuritySchemeType.ApiKey
                //});
                opt.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            services.AddSwaggerExamplesFromAssemblyOf<Program>();
            /*Fin configuración Swagger*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseMiddleware<ExceptionMiddleware>();
            app.UseHttpsRedirection();

            app.UseRouting();

            /*Inicio configuración Swagger*/
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                foreach (var description in provider.ApiVersionDescriptions.OrderByDescending(o => o.GroupName))
                {
                    c.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });
            /*Fin configuración Swagger*/

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private string GetXmlDataAnnotationFilePath()
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            if (!File.Exists(xmlPath))
            {
                return null;
            }

            return xmlPath;
        }
    }
}
