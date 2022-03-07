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
    public class JornadasController : ApiBaseController
    {
        private readonly JornadasServices _jornadasService;
        public JornadasController(JornadasServices jornadasService)
        {
            _jornadasService = jornadasService;
        }
        
        [HttpGet("jornadas-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasFind()
        {
            return ApiServiceResult(await _jornadasService.ListAsync());
        }

        [HttpGet("jornadas-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasDetail(int id)
        {
            return ApiServiceResult(await _jornadasService.FindAsync(id));
        }

        [HttpGet("jornadas-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasList(int id)
        {
            return ApiServiceResult(await _jornadasService.DetailAsync(id));
        }

        [HttpPost("jornadas-create")]
        [SwaggerRequestExample(typeof(JornadasDto), typeof(CreateJornadasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateJornadasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateJornadasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(JornadasDto dto)
        {
            return ApiServiceResult(await _jornadasService.AddAsync(dto));
        }

        [HttpPut("jornadas-update")]
        [SwaggerRequestExample(typeof(JornadasDto), typeof(UpdateJornadasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateJornadasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateJornadasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(JornadasDto dto)
        {
            return ApiServiceResult(await _jornadasService.EditAsync(dto));
        }

        [HttpPut("jornadas-delete")]
        [SwaggerRequestExample(typeof(JornadasDto), typeof(DeleteJornadasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteJornadasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteJornadasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _jornadasService.DeleteAsync(id));
        }
    }
}
