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
    public class EmpleadosController : ApiBaseController
    {
        private readonly EmpleadosService _empleadosService;
        public EmpleadosController(EmpleadosService empleadosService)
        {
            _empleadosService = empleadosService;
        }

        [HttpGet(ApiUrl.Empleados.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListEmpleadosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EmpleadosList()
        {
            return ApiServiceResult(await _empleadosService.ListAsync());
        }

        [HttpGet(ApiUrl.Empleados.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(FindEmpleadosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EmpleadosFind(int id)
        {
            return ApiServiceResult(await _empleadosService.FindAsync(id));
        }

        [HttpPost(ApiUrl.Empleados.Create)]
        [SwaggerRequestExample(typeof(EmpleadosCreateDto), typeof(CreateEmpleadosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateEmpleadosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateEmpleadosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] EmpleadosCreateDto dto)
        {
            return ApiServiceResult(await _empleadosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Empleados.Update)]
        [SwaggerRequestExample(typeof(EmpleadosUpdateDto), typeof(UpdateEmpleadosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateEmpleadosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateEmpleadosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(EmpleadosUpdateDto dto)
        {
            return ApiServiceResult(await _empleadosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Empleados.Delete)]
        [SwaggerRequestExample(typeof(EmpleadosDto), typeof(DeleteEmpleadosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteEmpleadosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteEmpleadosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _empleadosService.DeleteAsync(id));
        }
    }
}
