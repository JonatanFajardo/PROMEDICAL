using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListCirugiasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<CirugiasDto>()
                {
                    new CirugiasDto()
                    {
                        ciru_Id = 445,
                        ciru_Descripcion =    ""
                    },
                    new CirugiasDto()
                    {
                        ciru_Id = 123,
                        ciru_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateCirugiasExamples : IExamplesProvider<CirugiasDto>
    {
        public CirugiasDto GetExamples()
        {
            return new CirugiasDto()
            {
                ciru_Id = 528,
                ciru_Descripcion = ""
            };
        }
    }

    public class CreateCirugiasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateCirugiasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateCirugiasExamples : IExamplesProvider<CirugiasDto>
    {
        public CirugiasDto GetExamples()
        {
            return new CirugiasDto()
            {
                ciru_Id = 172,
                ciru_Descripcion = ""
            };
        }
    }

    public class UpdateCirugiasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateCirugiasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteCirugiasExamples : IExamplesProvider<CirugiasDto>
    {
        public CirugiasDto GetExamples()
        {
            return new CirugiasDto()
            {
                ciru_Id = 983
            };
        }
    }

    public class DeleteCirugiasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteCirugiasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
