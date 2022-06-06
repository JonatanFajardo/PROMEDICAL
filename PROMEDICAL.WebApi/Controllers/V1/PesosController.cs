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
    public class PesosController : ApiBaseController
    {
        private readonly PesosService _pesosService;
        public PesosController(PesosService pesosService)
        {
            _pesosService = pesosService;
        }

        [HttpGet(ApiUrl.Pesos.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosList()
        {
            return ApiServiceResult(await _pesosService.ListAsync());
        }

        [HttpGet(ApiUrl.Pesos.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosFind(int id)
        {
            return ApiServiceResult(await _pesosService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Pesos.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosDetail(int id)
        {
            return ApiServiceResult(await _pesosService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Pesos.Create)]
        [SwaggerRequestExample(typeof(Pesos_CreateDto), typeof(CreatePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreatePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreatePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(Pesos_CreateDto dto)
        {
            return ApiServiceResult(await _pesosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Pesos.Update)]
        [SwaggerRequestExample(typeof(Pesos_UpdateDto), typeof(UpdatePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdatePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdatePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(Pesos_UpdateDto dto)
        {
            return ApiServiceResult(await _pesosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Pesos.Delete)]
        [SwaggerRequestExample(typeof(Pesos_CreateDto), typeof(DeletePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeletePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeletePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _pesosService.DeleteAsync(id));
        }
    }
}
