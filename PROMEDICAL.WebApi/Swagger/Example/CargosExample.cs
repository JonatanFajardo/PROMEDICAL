using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListCargosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<CargosSelectDto>()
                {
                    new CargosSelectDto()
                    {
                        carg_Id = 383,
                        carg_Descripcion =    "Defensor del paciente"
                    },
                    new CargosSelectDto()
                    {
                        carg_Id = 15,
                        carg_Descripcion =    "Fisioterapeutas"
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateCargosExamples : IExamplesProvider<CargosCreateDto>
    {
        public CargosCreateDto GetExamples()
        {
            return new CargosCreateDto()
            {
                carg_Descripcion = "Logopedas"
            };
        }
    }

    public class CreateCargosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateCargosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateCargosExamples : IExamplesProvider<CargosUpdateDto>
    {
        public CargosUpdateDto GetExamples()
        {
            return new CargosUpdateDto()
            {
                carg_Id = 491,
                carg_Descripcion = "Trabajadores sociales"
            };
        }
    }

    public class UpdateCargosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateCargosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteCargosExamples : IExamplesProvider<CargosDeleteDto>
    {
        public CargosDeleteDto GetExamples()
        {
            return new CargosDeleteDto()
            {
                carg_Id = 758
            };
        }
    }

    public class DeleteCargosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteCargosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
