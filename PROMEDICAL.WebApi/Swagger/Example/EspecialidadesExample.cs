using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListEspecialidadesResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<EspecialidadesDto>()
                {
                    new EspecialidadesDto()
                    {
                        espc_Id = 542,
                        espc_Descripcion =    ""
                    },
                    new EspecialidadesDto()
                    {
                        espc_Id = 182,
                        espc_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateEspecialidadesExamples : IExamplesProvider<EspecialidadesDto>
    {
        public EspecialidadesDto GetExamples()
        {
            return new EspecialidadesDto()
            {
                espc_Id = 654,
                espc_Descripcion = ""
            };
        }
    }

    public class CreateEspecialidadesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateEspecialidadesErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateEspecialidadesExamples : IExamplesProvider<EspecialidadesDto>
    {
        public EspecialidadesDto GetExamples()
        {
            return new EspecialidadesDto()
            {
                espc_Id = 544,
                espc_Descripcion = ""
            };
        }
    }

    public class UpdateEspecialidadesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateEspecialidadesErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteEspecialidadesExamples : IExamplesProvider<EspecialidadesDto>
    {
        public EspecialidadesDto GetExamples()
        {
            return new EspecialidadesDto()
            {
                espc_Id = 422
            };
        }
    }

    public class DeleteEspecialidadesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteEspecialidadesErrorResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operación completada exitosamente.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
