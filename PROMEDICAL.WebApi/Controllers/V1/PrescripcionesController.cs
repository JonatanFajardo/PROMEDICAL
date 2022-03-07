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
    public class PrescripcionesController : ApiBaseController
    {
        private readonly PrescripcionesService _prescripcionesService;
        public PrescripcionesController(PrescripcionesService prescripcionesService)
        {
            _prescripcionesService = prescripcionesService;
        }
        
        [HttpGet("prescripciones-list")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesFind()
        {
            return ApiServiceResult(await _prescripcionesService.ListAsync());
        }

        [HttpGet("prescripciones-find")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesDetail(int id)
        {
            return ApiServiceResult(await _prescripcionesService.FindAsync(id));
        }

        [HttpGet("prescripciones-detail")]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesList(int id)
        {
            return ApiServiceResult(await _prescripcionesService.DetailAsync(id));
        }

        [HttpPost("prescripciones-create")]
        [SwaggerRequestExample(typeof(PrescripcionesDto), typeof(CreatePrescripcionesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreatePrescripcionesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreatePrescripcionesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(PrescripcionesDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.AddAsync(dto));
        }

        [HttpPut("prescripciones-update")]
        [SwaggerRequestExample(typeof(PrescripcionesDto), typeof(UpdatePrescripcionesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdatePrescripcionesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdatePrescripcionesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(PrescripcionesDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.EditAsync(dto));
        }

        [HttpPut("prescripciones-delete")]
        [SwaggerRequestExample(typeof(PrescripcionesDto), typeof(DeletePrescripcionesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeletePrescripcionesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeletePrescripcionesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _prescripcionesService.DeleteAsync(id));
        }
    }
}
