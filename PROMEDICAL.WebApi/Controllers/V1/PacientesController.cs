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
    public class PacientesController : ApiBaseController
    {
        private readonly PacientesService _empleadosService;
        public PacientesController(PacientesService empleadosService)
        {
            _empleadosService = empleadosService;
        }

        [HttpGet(ApiUrl.Pacientes.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPacientesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PacientesList()
        {
            return ApiServiceResult(await _empleadosService.ListAsync());
        }

        [HttpGet(ApiUrl.Pacientes.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(FindPacientesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PacientesFind(int id)
        {
            return ApiServiceResult(await _empleadosService.FindAsync(id));
        }

        [HttpPost(ApiUrl.Pacientes.Create)]
        [SwaggerRequestExample(typeof(Pacientes_CreateDto), typeof(CreatePacientesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreatePacientesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreatePacientesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] Pacientes_CreateDto dto)
        {
            return ApiServiceResult(await _empleadosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Pacientes.Update)]
        [SwaggerRequestExample(typeof(Pacientes_UpdateDto), typeof(UpdatePacientesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdatePacientesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdatePacientesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(Pacientes_UpdateDto dto)
        {
            return ApiServiceResult(await _empleadosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Pacientes.Delete)]
        [SwaggerRequestExample(typeof(PacientesDto), typeof(DeletePacientesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeletePacientesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeletePacientesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _empleadosService.DeleteAsync(id));
        }
    }
}
