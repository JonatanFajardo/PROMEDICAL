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
                Data = new List<Jornadas_SelectDto>()
                {
                    new Jornadas_SelectDto()
                    {
                        jorn_Id = 704,
                        jorn_Descripcion =    "Matutina"
                    },
                    new Jornadas_SelectDto()
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
    public class CreateJornadasExamples : IExamplesProvider<Jornadas_CreateDto>
    {
        public Jornadas_CreateDto GetExamples()
        {
            return new Jornadas_CreateDto()
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
    public class UpdateJornadasExamples : IExamplesProvider<Jornadas_UpdateDto>
    {
        public Jornadas_UpdateDto GetExamples()
        {
            return new Jornadas_UpdateDto()
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
    public class DeleteJornadasExamples : IExamplesProvider<Jornadas_DeleteDto>
    {
        public Jornadas_DeleteDto GetExamples()
        {
            return new Jornadas_DeleteDto()
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
