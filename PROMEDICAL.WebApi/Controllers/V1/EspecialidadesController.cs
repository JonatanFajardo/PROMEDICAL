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
    public class EspecialidadesController : ApiBaseController
    {
        private readonly EspecialidadesService _especialidadesService;
        public EspecialidadesController(EspecialidadesService especialidadesService)
        {
            _especialidadesService = especialidadesService;
        }
        
        [HttpGet("especialidades-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListEspecialidadesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EspecialidadesFind()
        {
            return ApiServiceResult(await _especialidadesService.ListAsync());
        }

        [HttpGet("especialidades-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListEspecialidadesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EspecialidadesDetail(int id)
        {
            return ApiServiceResult(await _especialidadesService.FindAsync(id));
        }

        [HttpGet("especialidades-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListEspecialidadesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EspecialidadesList(int id)
        {
            return ApiServiceResult(await _especialidadesService.DetailAsync(id));
        }

        [HttpPost("especialidades-create")]
        [SwaggerRequestExample(typeof(EspecialidadesDto), typeof(CreateEspecialidadesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateEspecialidadesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateEspecialidadesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(EspecialidadesDto dto)
        {
            return ApiServiceResult(await _especialidadesService.AddAsync(dto));
        }

        [HttpPut("especialidades-update")]
        [SwaggerRequestExample(typeof(EspecialidadesDto), typeof(UpdateEspecialidadesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateEspecialidadesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateEspecialidadesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(EspecialidadesDto dto)
        {
            return ApiServiceResult(await _especialidadesService.EditAsync(dto));
        }

        [HttpPut("especialidades-delete")]
        [SwaggerRequestExample(typeof(EspecialidadesDto), typeof(DeleteEspecialidadesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteEspecialidadesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteEspecialidadesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _especialidadesService.DeleteAsync(id));
        }
    }
}
