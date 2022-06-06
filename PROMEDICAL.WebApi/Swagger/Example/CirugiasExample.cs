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
                Data = new List<CirugiasSelectDto>()
                {
                    new CirugiasSelectDto()
                    {
                        ciru_Id = 445,
                        ciru_Descripcion =    "Cirugía menor"
                    },
                    new CirugiasSelectDto()
                    {
                        ciru_Id = 123,
                        ciru_Descripcion =    "Cirugía electiva"
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateCirugiasExamples : IExamplesProvider<CirugiasCreateDto>
    {
        public CirugiasCreateDto GetExamples()
        {
            return new CirugiasCreateDto()
            {
                ciru_Descripcion = "Cirugía de emergencia o de urgencia"
            };
        }
    }

    public class CreateCirugiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateCirugiasExamples : IExamplesProvider<CirugiasUpdateDto>
    {
        public CirugiasUpdateDto GetExamples()
        {
            return new CirugiasUpdateDto()
            {
                ciru_Id = 172,
                ciru_Descripcion = "Cirugía mayor"
            };
        }
    }

    public class UpdateCirugiasOKResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteCirugiasExamples : IExamplesProvider<CirugiasDeleteDto>
    {
        public CirugiasDeleteDto GetExamples()
        {
            return new CirugiasDeleteDto()
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
                Message = "Operación completada exitosamente.",
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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
