using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListTipoCitasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<TipoCitasSelectDto>()
                {
                    new TipoCitasSelectDto()
                    {
                        tici_Id = 908,
                        tici_Descripcion =    ""
                    },
                    new TipoCitasSelectDto()
                    {
                        tici_Id = 492,
                        tici_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateTipoCitasExamples : IExamplesProvider<TipoCitasCreateDto>
    {
        public TipoCitasCreateDto GetExamples()
        {
            return new TipoCitasCreateDto()
            {
                tici_Descripcion = ""
            };
        }
    }

    public class CreateTipoCitasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateTipoCitasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateTipoCitasExamples : IExamplesProvider<TipoCitasUpdateDto>
    {
        public TipoCitasUpdateDto GetExamples()
        {
            return new TipoCitasUpdateDto()
            {
                tici_Id = 924,
                tici_Descripcion = ""
            };
        }
    }

    public class UpdateTipoCitasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateTipoCitasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteTipoCitasExamples : IExamplesProvider<TipoCitasDeleteDto>
    {
        public TipoCitasDeleteDto GetExamples()
        {
            return new TipoCitasDeleteDto()
            {
                tici_Id = 540
            };
        }
    }

    public class DeleteTipoCitasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteTipoCitasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
