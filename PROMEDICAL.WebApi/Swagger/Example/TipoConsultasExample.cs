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
                Data = new List<TipoConsultasDto>()
                {
                    new TipoConsultasDto()
                    {
                        tico_Id = 189,
                        tico_Descripcion =    ""
                    },
                    new TipoConsultasDto()
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
    public class CreateTipoConsultasExamples : IExamplesProvider<TipoConsultasDto>
    {
        public TipoConsultasDto GetExamples()
        {
            return new TipoConsultasDto()
            {
                tico_Id = 691,
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
                Message = "creado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateTipoConsultasExamples : IExamplesProvider<TipoConsultasDto>
    {
        public TipoConsultasDto GetExamples()
        {
            return new TipoConsultasDto()
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
                Message = "modificado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteTipoConsultasExamples : IExamplesProvider<TipoConsultasDto>
    {
        public TipoConsultasDto GetExamples()
        {
            return new TipoConsultasDto()
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
                Message = "eliminado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
