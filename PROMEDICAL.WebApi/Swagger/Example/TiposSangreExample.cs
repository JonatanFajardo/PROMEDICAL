using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListTiposSangreResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<TiposSangre_SelectDto>()
                {
                    new TiposSangre_SelectDto()
                    {
                        tipsan_Id = 542,
                        tipsan_Descripcion =    ""
                    },
                    new TiposSangre_SelectDto()
                    {
                        tipsan_Id = 182,
                        tipsan_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateTiposSangreExamples : IExamplesProvider<TiposSangre_CreateDto>
    {
        public TiposSangre_CreateDto GetExamples()
        {
            return new TiposSangre_CreateDto()
            {
                tipsan_Descripcion = ""
            };
        }
    }

    public class CreateTiposSangreOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateTiposSangreErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateTiposSangreExamples : IExamplesProvider<TiposSangre_UpdateDto>
    {
        public TiposSangre_UpdateDto GetExamples()
        {
            return new TiposSangre_UpdateDto()
            {
                tipsan_Id = 544,
                tipsan_Descripcion = ""
            };
        }
    }

    public class UpdateTiposSangreOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateTiposSangreErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteTiposSangreExamples : IExamplesProvider<TiposSangre_DeleteDto>
    {
        public TiposSangre_DeleteDto GetExamples()
        {
            return new TiposSangre_DeleteDto()
            {
                tipsan_Id = 422
            };
        }
    }

    public class DeleteTiposSangreOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteTiposSangreErrorResponseExamples : IExamplesProvider<ServiceResult>
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
