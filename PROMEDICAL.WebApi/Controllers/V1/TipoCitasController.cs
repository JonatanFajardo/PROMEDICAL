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
    public class TipoCitasController : ApiBaseController
    {
        private readonly TipoCitasService _tipocitasService;
        public TipoCitasController(TipoCitasService tipocitasService)
        {
            _tipocitasService = tipocitasService;
        }
        
        [HttpGet("tipocitas-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasFind()
        {
            return ApiServiceResult(await _tipocitasService.ListAsync());
        }

        [HttpGet("tipocitas-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasDetail(int id)
        {
            return ApiServiceResult(await _tipocitasService.FindAsync(id));
        }

        [HttpGet("tipocitas-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasList(int id)
        {
            return ApiServiceResult(await _tipocitasService.DetailAsync(id));
        }

        [HttpPost("tipocitas-create")]
        [SwaggerRequestExample(typeof(TipoCitasDto), typeof(CreateTipoCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateTipoCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateTipoCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(TipoCitasDto dto)
        {
            return ApiServiceResult(await _tipocitasService.AddAsync(dto));
        }

        [HttpPut("tipocitas-update")]
        [SwaggerRequestExample(typeof(TipoCitasDto), typeof(UpdateTipoCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateTipoCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateTipoCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(TipoCitasDto dto)
        {
            return ApiServiceResult(await _tipocitasService.EditAsync(dto));
        }

        [HttpPut("tipocitas-delete")]
        [SwaggerRequestExample(typeof(TipoCitasDto), typeof(DeleteTipoCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteTipoCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteTipoCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _tipocitasService.DeleteAsync(id));
        }
    }
}
