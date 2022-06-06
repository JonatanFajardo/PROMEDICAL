using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListTipoConsultasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<TipoConsultasSelectDto>()
                {
                    new TipoConsultasSelectDto()
                    {
                        tico_Id = 189,
                        tico_Descripcion =    ""
                    },
                    new TipoConsultasSelectDto()
                    {
                        tico_Id = 221,
                        tico_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateTipoConsultasExamples : IExamplesProvider<TipoConsultasCreateDto>
    {
        public TipoConsultasCreateDto GetExamples()
        {
            return new TipoConsultasCreateDto()
            {
                tico_Descripcion = ""
            };
        }
    }

    public class CreateTipoConsultasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateTipoConsultasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateTipoConsultasExamples : IExamplesProvider<TipoConsultasUpdateDto>
    {
        public TipoConsultasUpdateDto GetExamples()
        {
            return new TipoConsultasUpdateDto()
            {
                tico_Id = 713,
                tico_Descripcion = ""
            };
        }
    }

    public class UpdateTipoConsultasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateTipoConsultasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteTipoConsultasExamples : IExamplesProvider<TipoConsultasDeleteDto>
    {
        public TipoConsultasDeleteDto GetExamples()
        {
            return new TipoConsultasDeleteDto()
            {
                tico_Id = 392
            };
        }
    }

    public class DeleteTipoConsultasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteTipoConsultasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
