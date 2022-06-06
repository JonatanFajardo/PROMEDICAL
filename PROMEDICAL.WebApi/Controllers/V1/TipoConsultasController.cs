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
    public class TipoConsultasController : ApiBaseController
    {
        private readonly TipoConsultasService _tipoconsultasService;
        public TipoConsultasController(TipoConsultasService tipoconsultasService)
        {
            _tipoconsultasService = tipoconsultasService;
        }

        [HttpGet(ApiUrl.TipoConsultas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoConsultasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoConsultasList()
        {
            return ApiServiceResult(await _tipoconsultasService.ListAsync());
        }

        [HttpGet(ApiUrl.TipoConsultas.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoConsultasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoConsultasFind(int id)
        {
            return ApiServiceResult(await _tipoconsultasService.FindAsync(id));
        }

        [HttpGet(ApiUrl.TipoConsultas.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTipoConsultasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TipoConsultasDetail(int id)
        {
            return ApiServiceResult(await _tipoconsultasService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.TipoConsultas.Create)]
        [SwaggerRequestExample(typeof(TipoConsultasCreateDto), typeof(CreateTipoConsultasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateTipoConsultasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateTipoConsultasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(TipoConsultasCreateDto dto)
        {
            return ApiServiceResult(await _tipoconsultasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.TipoConsultas.Update)]
        [SwaggerRequestExample(typeof(TipoConsultasUpdateDto), typeof(UpdateTipoConsultasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateTipoConsultasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateTipoConsultasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(TipoConsultasUpdateDto dto)
        {
            return ApiServiceResult(await _tipoconsultasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.TipoConsultas.Delete)]
        [SwaggerRequestExample(typeof(TipoConsultasUpdateDto), typeof(DeleteTipoConsultasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteTipoConsultasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteTipoConsultasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _tipoconsultasService.DeleteAsync(id));
        }
    }
}
