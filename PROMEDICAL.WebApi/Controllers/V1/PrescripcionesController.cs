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
    public class PrescripcionesController : ApiBaseController
    {
        private readonly PrescripcionesService _prescripcionesService;
        public PrescripcionesController(PrescripcionesService prescripcionesService)
        {
            _prescripcionesService = prescripcionesService;
        }
        
        [HttpGet(ApiUrl.Prescripciones.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesList(int id)
        {
            return ApiServiceResult(await _prescripcionesService.ListAsync(id));
        }

        [HttpGet(ApiUrl.Prescripciones.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesFind(int id)
        {
            return ApiServiceResult(await _prescripcionesService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Prescripciones.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListPrescripcionesResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> PrescripcionesDetail(int id)
        {
            return ApiServiceResult(await _prescripcionesService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Prescripciones.Create)]
        [SwaggerRequestExample(typeof(Prescripciones_CreateDto), typeof(CreatePrescripcionesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreatePrescripcionesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreatePrescripcionesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(Prescripciones_CreateDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Prescripciones.Update)]
        [SwaggerRequestExample(typeof(Prescripciones_UpdateDto), typeof(UpdatePrescripcionesExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdatePrescripcionesOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdatePrescripcionesErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(Prescripciones_UpdateDto dto)
        {
            return ApiServiceResult(await _prescripcionesService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Prescripciones.Delete)]
        [SwaggerRequestExample(typeof(Prescripciones_CreateDto), typeof(DeletePrescripcionesExamples))]
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
