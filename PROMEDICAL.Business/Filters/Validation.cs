using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PROMEDICAL.Business.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDICAL.Business.Filters
{
    public class Validation : IAsyncActionFilter
    {
        //public async Task<object> OnActionExecutingAsync(ActionExecutingContext context, )
        //{

        //    throw new NotImplementedException();
        //}
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                ApiServiceResult apiServiceResult = new ApiServiceResult()
                {
                    Success = false,
                    Type = ServiceResultType.BadRequest
                };
                
                context.Result = new BadRequestObjectResult(apiServiceResult);
                return;
            }
            await next();
        }
    }
}
