using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PROMEDICAL.Business.Extensions;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        //public async Task<object> OnActionExecutingAsync(ActionExecutingContext context, )
        //{

        //    throw new NotImplementedException();
        //}
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                ServiceResult apiServiceResult = new ServiceResult()
                {
                    Success = false,

                    Type = ServiceResultType.BadRequest,
                    Message = "alamadre"
                };

                context.Result = new JsonResult(apiServiceResult);
                return;
            }
            await next();
        }
    }
}
