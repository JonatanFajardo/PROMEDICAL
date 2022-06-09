using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PROMEDICAL.Business.Extensions;
using System;
using System.Net;
using System.Threading.Tasks;

namespace PROMEDICAL.Business
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ExceptionMiddleware>();
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            transaction
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Oooops!Algo salió mal:sass");
                await InternalServerErrorHandleGlobalExceptionAsync(httpContext, ex);
            }
        }

        private static Task InternalServerErrorHandleGlobalExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            //if (context.sta)
            //{

            //}
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Error();

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(JsonConvert.SerializeObject(serviceResult));
        }
    }
}
