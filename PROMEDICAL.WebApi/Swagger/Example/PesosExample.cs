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
                Data = new List<PesosDto>()
                {
                    new PesosDto()
                    {
                        peso_Id = 566,
                        paci_Id = 0,
                        peso_Descripcion =    ""
                    },
                    new PesosDto()
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
    public class CreatePesosExamples : IExamplesProvider<PesosDto>
    {
        public PesosDto GetExamples()
        {
            return new PesosDto()
            {
                peso_Id = 592,
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
                Message = "creado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdatePesosExamples : IExamplesProvider<PesosDto>
    {
        public PesosDto GetExamples()
        {
            return new PesosDto()
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
                Message = "modificado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeletePesosExamples : IExamplesProvider<PesosDto>
    {
        public PesosDto GetExamples()
        {
            return new PesosDto()
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
                Message = "eliminado exitosamente.",
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
                Message = "Se produjo un error",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
