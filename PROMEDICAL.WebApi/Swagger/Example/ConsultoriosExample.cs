using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListConsultoriosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<ConsultoriosSelectDto>()
                {
                    new ConsultoriosSelectDto()
                    {
                        cons_Id = 449,
                        cons_Descripcion =    "A2"
                    },
                    new ConsultoriosSelectDto()
                    {
                        cons_Id = 857,
                        cons_Descripcion =    "A3"
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateConsultoriosExamples : IExamplesProvider<ConsultoriosCreateDto>
    {
        public ConsultoriosCreateDto GetExamples()
        {
            return new ConsultoriosCreateDto()
            {
                cons_Descripcion = "A4"
            };
        }
    }

    public class CreateConsultoriosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateConsultoriosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateConsultoriosExamples : IExamplesProvider<ConsultoriosUpdateDto>
    {
        public ConsultoriosUpdateDto GetExamples()
        {
            return new ConsultoriosUpdateDto()
            {
                cons_Id = 264,
                cons_Descripcion = "A5"
            };
        }
    }

    public class UpdateConsultoriosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateConsultoriosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteConsultoriosExamples : IExamplesProvider<ConsultoriosDeleteDto>
    {
        public ConsultoriosDeleteDto GetExamples()
        {
            return new ConsultoriosDeleteDto()
            {
                cons_Id = 346
            };
        }
    }

    public class DeleteConsultoriosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteConsultoriosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
