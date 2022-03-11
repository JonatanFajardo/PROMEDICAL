using Microsoft.AspNetCore.Mvc;
using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
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
    public class TiposSangreController : ApiBaseController
    {
        private readonly TiposSangreService _especialidadesService;
        public TiposSangreController(TiposSangreService especialidadesService)
        {
            _especialidadesService = especialidadesService;
        }
        
        [HttpGet(ApiUrl.Especialidades.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreFind()
        {
            return ApiServiceResult(await _especialidadesService.ListAsync());
        }

        [HttpGet(ApiUrl.Especialidades.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreDetail(int id)
        {
            return ApiServiceResult(await _especialidadesService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Especialidades.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreList(int id)
        {
            return ApiServiceResult(await _especialidadesService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Especialidades.Create)]
        [SwaggerRequestExample(typeof(TiposSangreDto), typeof(CreateTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(TiposSangreDto dto)
        {
            return ApiServiceResult(await _especialidadesService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Especialidades.Update)]
        [SwaggerRequestExample(typeof(TiposSangreDto), typeof(UpdateTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(TiposSangreDto dto)
        {
            return ApiServiceResult(await _especialidadesService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Especialidades.Delete)]
        [SwaggerRequestExample(typeof(TiposSangreDto), typeof(DeleteTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _especialidadesService.DeleteAsync(id));
        }
    }
}
