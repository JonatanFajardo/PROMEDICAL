using Microsoft.AspNetCore.Mvc;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Business.Filters;
using PROMEDICAL.Business.Services;
using PROMEDICAL.Business.Utilities;
using PROMEDICAL.WebApi.Swagger.Example;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System.Net;
using System.Threading.Tasks;

namespace PROMEDICAL.WebApi.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(ValidationFilter))]
    [Produces("application/json")]
    public class FrecuenciasCardiacasController : ApiBaseController
    {
        private readonly FrecuenciasCardiacasService _frecuenciasCardiacas;
        public FrecuenciasCardiacasController(FrecuenciasCardiacasService FrecuenciasCardiacasService)
        {
            _frecuenciasCardiacas = FrecuenciasCardiacasService;
        }
        
        [HttpGet(ApiUrl.FrecuenciasCardiacas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListFrecuenciasCardiacasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> FrecuenciasCardiacasFind(int id)
        {
            return ApiServiceResult(await _frecuenciasCardiacas.ListAsync(id));
        }

        [HttpPost(ApiUrl.FrecuenciasCardiacas.Create)]
        [SwaggerRequestExample(typeof(FrecuenciasCardiacas_CreateDto), typeof(CreateFrecuenciasCardiacasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateFrecuenciasCardiacasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateFrecuenciasCardiacasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] FrecuenciasCardiacas_CreateDto dto)
        {
            return ApiServiceResult(await _frecuenciasCardiacas.AddAsync(dto));
        }

        //[HttpPut(ApiUrl.FrecuenciasCardiacas.Update)]
        //[SwaggerRequestExample(typeof(FrecuenciasCardiacas_UpdateDto), typeof(UpdateFrecuenciasCardiacasExamples))]
        //[SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateFrecuenciasCardiacasOKResponseExamples))]
        //[SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateFrecuenciasCardiacasErrorResponseExamples))]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        //public async Task<IActionResult> Update(FrecuenciasCardiacas_UpdateDto dto)
        //{
        //    return ApiServiceResult(await _frecuenciasCardiacas.EditAsync(dto));
        //}

        //[HttpPut(ApiUrl.FrecuenciasCardiacas.Delete)]
        //[SwaggerRequestExample(typeof(FrecuenciasCardiacas_CreateDto), typeof(DeleteFrecuenciasCardiacasExamples))]
        //[SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteFrecuenciasCardiacasOKResponseExamples))]
        //[SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteFrecuenciasCardiacasErrorResponseExamples))]
        //[SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return ApiServiceResult(await _frecuenciasCardiacas.DeleteAsync(id));
        //}
    }
}
