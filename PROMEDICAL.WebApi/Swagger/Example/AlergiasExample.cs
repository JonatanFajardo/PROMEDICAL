using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListAlergiasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<AlergiasDto>()
                {
                    new AlergiasDto()
                    {
                        algi_Id = 198,
                        algi_Descripcion =    ""
                    },
                    new AlergiasDto()
                    {
                        algi_Id = 92,
                        algi_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateAlergiasExamples : IExamplesProvider<AlergiasDto>
    {
        public AlergiasDto GetExamples()
        {
            return new AlergiasDto()
            {
                algi_Id = 604,
                algi_Descripcion = ""
            };
        }
    }

    public class CreateAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "creado exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class CreateAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateAlergiasExamples : IExamplesProvider<AlergiasDto>
    {
        public AlergiasDto GetExamples()
        {
            return new AlergiasDto()
            {
                algi_Id = 929,
                algi_Descripcion = ""
            };
        }
    }

    public class UpdateAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "modificado exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class UpdateAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteAlergiasExamples : IExamplesProvider<AlergiasDto>
    {
        public AlergiasDto GetExamples()
        {
            return new AlergiasDto()
            {
                algi_Id = 743
            };
        }
    }

    public class DeleteAlergiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "eliminado exitosamente.",
                Success = true,
                Type = ServiceResultType.Success,
                Data = null
            };
        }
    }

    public class DeleteAlergiasErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
