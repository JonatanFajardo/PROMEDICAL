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
    public class TiposSangreController : ApiBaseController
    {
        private readonly TiposSangreService _tiposSangreService;
        public TiposSangreController(TiposSangreService tiposSangreService)
        {
            _tiposSangreService = tiposSangreService;
        }

        [HttpGet(ApiUrl.TiposSangre.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreList()
        {
            return ApiServiceResult(await _tiposSangreService.ListAsync());
        }

        [HttpGet(ApiUrl.TiposSangre.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreFind(int id)
        {
            return ApiServiceResult(await _tiposSangreService.FindAsync(id));
        }

        [HttpGet(ApiUrl.TiposSangre.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListTiposSangreResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> TiposSangreDetail(int id)
        {
            return ApiServiceResult(await _tiposSangreService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.TiposSangre.Create)]
        [SwaggerRequestExample(typeof(TiposSangre_CreateDto), typeof(CreateTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(TiposSangre_CreateDto dto)
        {
            return ApiServiceResult(await _tiposSangreService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.TiposSangre.Update)]
        [SwaggerRequestExample(typeof(TiposSangre_UpdateDto), typeof(UpdateTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(TiposSangre_UpdateDto dto)
        {
            return ApiServiceResult(await _tiposSangreService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.TiposSangre.Delete)]
        [SwaggerRequestExample(typeof(TiposSangre_UpdateDto), typeof(DeleteTiposSangreExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteTiposSangreOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteTiposSangreErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _tiposSangreService.DeleteAsync(id));
        }
    }
}
