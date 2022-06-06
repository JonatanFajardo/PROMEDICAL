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
    public class EmpresasController : ApiBaseController
    {
        private readonly EmpresasService _empresasService;
        public EmpresasController(EmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        [HttpGet(ApiUrl.Empresas.List)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(ListEmpresasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EmpresasList()
        {
            return ApiServiceResult(await _empresasService.ListAsync());
        }

        [HttpGet(ApiUrl.Empresas.Find)]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(FindEmpresasResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        public async Task<IActionResult> EmpresasFind(int id)
        {
            return ApiServiceResult(await _empresasService.FindAsync(id));
        }

        [HttpPost(ApiUrl.Empresas.Create)]
        [SwaggerRequestExample(typeof(EmpresasCreateDto), typeof(CreateEmpresasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(CreateEmpresasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(CreateEmpresasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Create([FromBody] EmpresasCreateDto dto)
        {
            return ApiServiceResult(await _empresasService.AddAsync(dto));
        }

        [HttpPut(ApiUrl.Empresas.Update)]
        [SwaggerRequestExample(typeof(EmpresasUpdateDto), typeof(UpdateEmpresasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(UpdateEmpresasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(UpdateEmpresasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Update(EmpresasUpdateDto dto)
        {
            return ApiServiceResult(await _empresasService.EditAsync(dto));
        }

        [HttpPut(ApiUrl.Empresas.Delete)]
        [SwaggerRequestExample(typeof(EmpresasDto), typeof(DeleteEmpresasExamples))]
        [SwaggerResponseExample((int)HttpStatusCode.OK, typeof(DeleteEmpresasOKResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ServiceResult))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(DeleteEmpresasErrorResponseExamples))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Type = typeof(ServiceResult))]
        public async Task<IActionResult> Delete(int id)
        {
            return ApiServiceResult(await _empresasService.DeleteAsync(id));
        }
    }
}
