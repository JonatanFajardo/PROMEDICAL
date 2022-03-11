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
    public class AlergiasController : ApiBaseController
    {
        private readonly AlergiasService _alergiasService;
        public AlergiasController(AlergiasService alergiasService)
        {
            _alergiasService = alergiasService;
        }
        
        [HttpGet(ApiUrl.Alergias.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListAlergiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> AlergiasFind()
        {
            return ApiServiceResult(await _alergiasService.ListAsync());
        }

        [HttpGet(ApiUrl.Alergias.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListAlergiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> AlergiasDetail(int id)
        {
            return ApiServiceResult(await _alergiasService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Alergias.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListAlergiasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> AlergiasList(int id)
        {
            return ApiServiceResult(await _alergiasService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Alergias.Create)]
        [SwaggerRequestExample(typeof(AlergiasDto), typeof(CreateAlergiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateAlergiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateAlergiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] AlergiasDto dto)
        {
            return ApiServiceResult(await _alergiasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Alergias.Update)]
        [SwaggerRequestExample(typeof(AlergiasDto), typeof(UpdateAlergiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateAlergiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateAlergiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(AlergiasDto dto)
        {
            return ApiServiceResult(await _alergiasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Alergias.Delete)]
        [SwaggerRequestExample(typeof(AlergiasDto), typeof(DeleteAlergiasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteAlergiasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteAlergiasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _alergiasService.DeleteAsync(id));
        }
    }
}
