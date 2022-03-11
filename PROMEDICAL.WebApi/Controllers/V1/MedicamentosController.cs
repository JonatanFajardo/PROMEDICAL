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
    public class MedicamentosController : ApiBaseController
    {
        private readonly MedicamentosService _medicamentosService;
        public MedicamentosController(MedicamentosService medicamentosService)
        {
            _medicamentosService = medicamentosService;
        }
        
        [HttpGet(ApiUrl.Medicamentos.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListMedicamentosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> MedicamentosFind()
        {
            return ApiServiceResult(await _medicamentosService.ListAsync());
        }

        [HttpGet(ApiUrl.Medicamentos.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListMedicamentosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> MedicamentosDetail(int id)
        {
            return ApiServiceResult(await _medicamentosService.FindAsync(id));
        }

        [HttpGet(ApiUrl.Medicamentos.Detail)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListMedicamentosResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> MedicamentosList(int id)
        {
            return ApiServiceResult(await _medicamentosService.DetailAsync(id));
        }

        [HttpPost(ApiUrl.Medicamentos.Create)]
        [SwaggerRequestExample(typeof(MedicamentosDto), typeof(CreateMedicamentosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateMedicamentosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateMedicamentosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create(MedicamentosDto dto)
        {
            return ApiServiceResult(await _medicamentosService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Medicamentos.Update)]
        [SwaggerRequestExample(typeof(MedicamentosDto), typeof(UpdateMedicamentosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateMedicamentosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateMedicamentosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(MedicamentosDto dto)
        {
            return ApiServiceResult(await _medicamentosService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Medicamentos.Delete)]
        [SwaggerRequestExample(typeof(MedicamentosDto), typeof(DeleteMedicamentosExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteMedicamentosOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteMedicamentosErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _medicamentosService.DeleteAsync(id));
        }
    }
}
