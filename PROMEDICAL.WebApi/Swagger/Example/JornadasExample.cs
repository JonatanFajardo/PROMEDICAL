using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListJornadasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<JornadasSelectDto>()
                {
                    new JornadasSelectDto()
                    {
                        jorn_Id = 704,
                        jorn_Descripcion =    "Matutina"
                    },
                    new JornadasSelectDto()
                    {
                        jorn_Id = 224,
                        jorn_Descripcion =    "Vespertina"
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateJornadasExamples : IExamplesProvider<JornadasCreateDto>
    {
        public JornadasCreateDto GetExamples()
        {
            return new JornadasCreateDto()
            {
                jorn_Descripcion = "Vespertina"
            };
        }
    }

    public class CreateJornadasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateJornadasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateJornadasExamples : IExamplesProvider<JornadasUpdateDto>
    {
        public JornadasUpdateDto GetExamples()
        {
            return new JornadasUpdateDto()
            {
                jorn_Id = 758,
                jorn_Descripcion = "Matutina"
            };
        }
    }

    public class UpdateJornadasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateJornadasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteJornadasExamples : IExamplesProvider<JornadasDeleteDto>
    {
        public JornadasDeleteDto GetExamples()
        {
            return new JornadasDeleteDto()
            {
                jorn_Id = 757
            };
        }
    }

    public class DeleteJornadasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteJornadasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
