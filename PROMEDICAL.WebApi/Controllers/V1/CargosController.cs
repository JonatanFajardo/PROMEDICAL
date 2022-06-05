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
    public class CargosController : ApiBaseController
    {
        private readonly CargosService _cargosService;
        public CargosController(CargosService cargosService)
        {
            _cargosService = cargosService;
        }

        [HttpGet(ApiUrl.Cargos.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosFind()
        {
            return ApiServiceResult(await _cargosService.ListAsync());
        }

        [HttpGet(ApiUrl.Cargos.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosDetail(int id)
        {
            return ApiServiceResult(await _cargosService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Cargos.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCargosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CargosList(int id)
        {
            return ApiServiceResult(await _cargosService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Cargos.Create)]
        [SwaggerRequestExample(typeof(Cargos_CreateDto), typeof(CreateCargosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateCargosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateCargosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] Cargos_CreateDto dto)
        {
            return ApiServiceResult(await _cargosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Cargos.Update)]
        [SwaggerRequestExample(typeof(Cargos_UpdateDto), typeof(UpdateCargosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateCargosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateCargosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(Cargos_UpdateDto dto)
        {
            return ApiServiceResult(await _cargosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Cargos.Delete)]
        [SwaggerRequestExample(typeof(Cargos_CreateDto), typeof(DeleteCargosExamples))]
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
