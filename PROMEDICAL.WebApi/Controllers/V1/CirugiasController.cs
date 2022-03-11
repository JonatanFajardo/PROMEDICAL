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
    [TypeFilter(typeof(ValidationFilter))]
    [Produces("application/json")]
    public class CirugiasController : ApiBaseController
    {
        private readonly CirugiasService _cirugiasService;
        public CirugiasController(CirugiasService cirugiasService)
        {
            _cirugiasService = cirugiasService;
        }
        
        [HttpGet(ApiUrl.Cirugias.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCirugiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CirugiasFind()
        {
            return ApiServiceResult(await _cirugiasService.ListAsync());
        }

        [HttpGet(ApiUrl.Cirugias.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCirugiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CirugiasDetail(int id)
        {
            return ApiServiceResult(await _cirugiasService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Cirugias.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListCirugiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> CirugiasList(int id)
        {
            return ApiServiceResult(await _cirugiasService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Cirugias.Create)]
        [SwaggerRequestExample(typeof(CirugiasDto), typeof(CreateCirugiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateCirugiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateCirugiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(CirugiasDto dto)
        {
            return ApiServiceResult(await _cirugiasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Cirugias.Update)]
        [SwaggerRequestExample(typeof(CirugiasDto), typeof(UpdateCirugiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateCirugiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateCirugiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(CirugiasDto dto)
        {
            return ApiServiceResult(await _cirugiasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Cirugias.Delete)]
        [SwaggerRequestExample(typeof(CirugiasDto), typeof(DeleteCirugiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteCirugiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteCirugiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _cirugiasService.DeleteAsync(id));
        }
    }
}
