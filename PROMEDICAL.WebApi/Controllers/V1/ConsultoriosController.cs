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
    public class ConsultoriosController : ApiBaseController
    {
        private readonly ConsultoriosService _consultoriosService;
        public ConsultoriosController(ConsultoriosService consultoriosService)
        {
            _consultoriosService = consultoriosService;
        }

        [HttpGet(ApiUrl.Consultorios.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosList()
        {
            return ApiServiceResult(await _consultoriosService.ListAsync());
        }

        [HttpGet(ApiUrl.Consultorios.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosFind(int id)
        {
            return ApiServiceResult(await _consultoriosService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Consultorios.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListConsultoriosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> ConsultoriosDetail(int id)
        {
            return ApiServiceResult(await _consultoriosService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Consultorios.Create)]
        [SwaggerRequestExample(typeof(Consultorios_CreateDto), typeof(CreateConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(Consultorios_CreateDto dto)
        {
            return ApiServiceResult(await _consultoriosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Consultorios.Update)]
        [SwaggerRequestExample(typeof(Consultorios_UpdateDto), typeof(UpdateConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(Consultorios_UpdateDto dto)
        {
            return ApiServiceResult(await _consultoriosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Consultorios.Delete)]
        [SwaggerRequestExample(typeof(Consultorios_CreateDto), typeof(DeleteConsultoriosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteConsultoriosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteConsultoriosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _consultoriosService.DeleteAsync(id));
        }
    }
}
