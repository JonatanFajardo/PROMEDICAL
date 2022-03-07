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
    public class PesosController : ApiBaseController
    {
        private readonly PesosService _prescripcionesService;
        public PesosController(PesosService prescripcionesService)
        {
            _prescripcionesService = prescripcionesService;
        }
        
        [HttpGet("prescripciones-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosFind()
        {
            return ApiServiceResult(await _prescripcionesService.ListAsync());
        }

        [HttpGet("prescripciones-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosDetail(int id)
        {
            return ApiServiceResult(await _prescripcionesService.FindAsync(id));
        }

        [HttpGet("prescripciones-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPesosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PesosList(int id)
        {
            return ApiServiceResult(await _prescripcionesService.DetailAsync(id));
        }

        [HttpPost("prescripciones-create")]
        [SwaggerRequestExample(typeof(PesosDto), typeof(CreatePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreatePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreatePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(PesosDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.AddAsync(dto));
        }

        [HttpPut("prescripciones-update")]
        [SwaggerRequestExample(typeof(PesosDto), typeof(UpdatePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdatePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdatePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(PesosDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.EditAsync(dto));
        }

        [HttpPut("prescripciones-delete")]
        [SwaggerRequestExample(typeof(PesosDto), typeof(DeletePesosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeletePesosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeletePesosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _prescripcionesService.DeleteAsync(id));
        }
    }
}
