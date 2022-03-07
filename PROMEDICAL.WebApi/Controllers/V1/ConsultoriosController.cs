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
    public class ConsultoriosController : ApiBaseController
    {
        private readonly ConsultoriosService _cargosService;
        public ConsultoriosController(ConsultoriosService cargosService)
        {
            _cargosService = cargosService;
        }
        
        [HttpGet("cargos-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosFind()
        {
            return ApiServiceResult(await _cargosService.ListAsync());
        }

        [HttpGet("cargos-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosDetail(int id)
        {
            return ApiServiceResult(await _cargosService.FindAsync(id));
        }

        [HttpGet("cargos-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosList(int id)
        {
            return ApiServiceResult(await _cargosService.DetailAsync(id));
        }

        [HttpPost("cargos-create")]
        [SwaggerRequestExample(typeof(ConsultoriosDto), typeof(CreateConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(ConsultoriosDto dto)
        {
            return ApiServiceResult(await _cargosService.AddAsync(dto));
        }

        [HttpPut("cargos-update")]
        [SwaggerRequestExample(typeof(ConsultoriosDto), typeof(UpdateConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(ConsultoriosDto dto)
        {
            return ApiServiceResult(await _cargosService.EditAsync(dto));
        }

        [HttpPut("cargos-delete")]
        [SwaggerRequestExample(typeof(ConsultoriosDto), typeof(DeleteConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _cargosService.DeleteAsync(id));
        }
    }
}
