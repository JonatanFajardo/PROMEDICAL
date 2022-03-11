using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListPesosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Pesos_SelectDto>()
                {
                    new Pesos_SelectDto()
                    {
                        peso_Id = 566,
                        paci_Id = 0,
                        peso_Descripcion =    ""
                    },
                    new Pesos_SelectDto()
                    {
                        peso_Id = 217,
                        paci_Id = 0,
                        peso_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreatePesosExamples : IExamplesProvider<Pesos_CreateDto>
    {
        public Pesos_CreateDto GetExamples()
        {
            return new Pesos_CreateDto()
            {
                paci_Id = 0,
                peso_Descripcion = ""
            };
        }
    }

    public class CreatePesosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreatePesosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdatePesosExamples : IExamplesProvider<Pesos_UpdateDto>
    {
        public Pesos_UpdateDto GetExamples()
        {
            return new Pesos_UpdateDto()
            {
                peso_Id = 373,
                paci_Id = 0,
                peso_Descripcion = ""
            };
        }
    }

    public class UpdatePesosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdatePesosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeletePesosExamples : IExamplesProvider<Pesos_DeleteDto>
    {
        public Pesos_DeleteDto GetExamples()
        {
            return new Pesos_DeleteDto()
            {
                peso_Id = 204
            };
        }
    }

    public class DeletePesosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeletePesosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
