using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace PROMEDICAL.WebApi.Swagger
{
    public class SwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider _apiVerProvider;

        public SwaggerOptions(IApiVersionDescriptionProvider apiVerProvider) => _apiVerProvider = apiVerProvider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _apiVerProvider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, GetSwaggerDocInfo(description));
            }
        }

        static OpenApiInfo GetSwaggerDocInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = $"API {description.ApiVersion}",
                Version = description.GroupName,
                Description = "Utilice está api para el Helpdesk",
                Contact = new OpenApiContact()
                {
                    Name = "INSTA HELP Service"
                },
                License = new OpenApiLicense()
                {
                    Name = "All rights reserved (2021)."
                }
            };

            if (description.IsDeprecated)
            {
                info.Description += $" {description.ApiVersion} API version is deprecated.";
            }

            return info;
        }
    }
}
