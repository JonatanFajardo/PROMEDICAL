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
    public class JornadasController : ApiBaseController
    {
        private readonly JornadasServices _jornadasService;
        public JornadasController(JornadasServices jornadasService)
        {
            _jornadasService = jornadasService;
        }

        [HttpGet(ApiUrl.Jornadas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasList()
        {
            return ApiServiceResult(await _jornadasService.ListAsync());
        }

        [HttpGet(ApiUrl.Jornadas.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasFind(int id)
        {
            return ApiServiceResult(await _jornadasService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Jornadas.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListJornadasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> JornadasDetail(int id)
        {
            return ApiServiceResult(await _jornadasService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Jornadas.Create)]
        [SwaggerRequestExample(typeof(JornadasCreateDto), typeof(CreateJornadasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateJornadasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateJornadasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(JornadasCreateDto dto)
        {
            return ApiServiceResult(await _jornadasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Jornadas.Update)]
        [SwaggerRequestExample(typeof(JornadasUpdateDto), typeof(UpdateJornadasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateJornadasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateJornadasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(JornadasUpdateDto dto)
        {
            return ApiServiceResult(await _jornadasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Jornadas.Delete)]
        [SwaggerRequestExample(typeof(JornadasCreateDto), typeof(DeleteJornadasExamples))]
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
