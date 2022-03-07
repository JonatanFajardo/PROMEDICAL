using Microsoft.AspNetCore.Mvc;
using PROMEDICAL.Business.Extensions;

namespace PROMEDICAL.WebApi.Controllers
{
    public class ApiBaseController : Controller
    {
        protected IActionResult ApiServiceResult(ServiceResult result)
        {
            switch (result.Type)
            {
                case ServiceResultType.Success:
                case ServiceResultType.Info:
                case ServiceResultType.Warning:
                    return Ok(result);

                case ServiceResultType.BadRequest:
                    return BadRequest(result);

                case ServiceResultType.NotFound:
                    return NotFound(result);

                case ServiceResultType.Unauthorized:
                    return Unauthorized(result);

                case ServiceResultType.Forbidden:
                    return StatusCode(403, result);
                case ServiceResultType.NotAcceptable:
                    return StatusCode(406, result);
                case ServiceResultType.Disabled:
                    return StatusCode(410, result);
                case ServiceResultType.Conflict:
                    return Conflict(result);
                default:
                case ServiceResultType.Error:
                    return StatusCode(500, result);
            }
        }

        protected IActionResult ApiServiceResult(ServiceResult result, object data)
        {
            if (result == null)
                return BadRequest();

            result.Data = data;

            return ApiServiceResult(result);
        }
    }
}
