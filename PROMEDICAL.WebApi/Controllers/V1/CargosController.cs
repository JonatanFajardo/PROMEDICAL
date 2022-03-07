using Microsoft.AspNetCore.Mvc;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Business.Services;
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
    public class CargosController : ApiBaseController
    {
        private readonly CargosService _cargosService;
        public CargosController(CargosService cargosService)
        {
            _cargosService = cargosService;
        }
        
        [HttpGet("cargos-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosFind()
        {
            return ApiServiceResult(await _cargosService.ListAsync());
        }

        [HttpGet("cargos-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosDetail(int id)
        {
            return ApiServiceResult(await _cargosService.FindAsync(id));
        }

        [HttpGet("cargos-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosList(int id)
        {
            return ApiServiceResult(await _cargosService.DetailAsync(id));
        }

        [HttpPost("cargos-create")]
        [SwaggerRequestExample(typeof(CargosDto), typeof(CreateCargosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateCargosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateCargosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(CargosDto dto)
        {
            return ApiServiceResult(await _cargosService.AddAsync(dto));
        }

        [HttpPut("cargos-update")]
        [SwaggerRequestExample(typeof(CargosDto), typeof(UpdateCargosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateCargosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateCargosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(CargosDto dto)
        {
            return ApiServiceResult(await _cargosService.EditAsync(dto));
        }

        [HttpPut("cargos-delete")]
        [SwaggerRequestExample(typeof(CargosDto), typeof(DeleteCargosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteCargosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteCargosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _cargosService.DeleteAsync(id));
        }
    }
}
