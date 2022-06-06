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
    public class TipoCitasController : ApiBaseController
    {
        private readonly TipoCitasService _tipocitasService;
        public TipoCitasController(TipoCitasService tipocitasService)
        {
            _tipocitasService = tipocitasService;
        }

        [HttpGet(ApiUrl.TipoCitas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasList()
        {
            return ApiServiceResult(await _tipocitasService.ListAsync());
        }

        [HttpGet(ApiUrl.TipoCitas.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasFind(int id)
        {
            return ApiServiceResult(await _tipocitasService.FindAsync(id));
        }

        [HttpGet(ApiUrl.TipoCitas.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoCitasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoCitasDetail(int id)
        {
            return ApiServiceResult(await _tipocitasService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.TipoCitas.Create)]
        [SwaggerRequestExample(typeof(TipoCitas_CreateDto), typeof(CreateTipoCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateTipoCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateTipoCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(TipoCitas_CreateDto dto)
        {
            return ApiServiceResult(await _tipocitasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.TipoCitas.Update)]
        [SwaggerRequestExample(typeof(TipoCitas_UpdateDto), typeof(UpdateTipoCitasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateTipoCitasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateTipoCitasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(TipoCitas_UpdateDto dto)
        {
            return ApiServiceResult(await _tipocitasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.TipoCitas.Delete)]
        [SwaggerRequestExample(typeof(TipoCitas_CreateDto), typeof(DeleteTipoCitasExamples))]
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
