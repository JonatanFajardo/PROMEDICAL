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
    [Produces("application/json")]
    public class CitasController : ApiBaseController
    {
        private readonly CitasService _CitasService;
        public CitasController(CitasService CitasService)
        {
            _CitasService = CitasService;
        }
        
        [HttpGet(ApiUrl.Citas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CitasFind()
        {
            return ApiServiceResult(await _CitasService.ListAsync());
        }

        [HttpPost(ApiUrl.Citas.Create)]
        [SwaggerRequestExample(typeof(Citas_CreateDto), typeof(CreateCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] Citas_CreateDto dto)
        {
            return ApiServiceResult(await _CitasService.AddAsync(dto));
        }

    }
}
