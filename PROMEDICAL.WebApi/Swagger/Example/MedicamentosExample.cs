using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListMedicamentosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<MedicamentosDto>()
                {
                    new MedicamentosDto()
                    {
                        medi_Id = 854,
                        medi_Nombre =    ""
                    },
                    new MedicamentosDto()
                    {
                        medi_Id = 635,
                        medi_Nombre =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateMedicamentosExamples : IExamplesProvider<MedicamentosDto>
    {
        public MedicamentosDto GetExamples()
        {
            return new MedicamentosDto()
            {
                medi_Id = 344,
                medi_Nombre = ""
            };
        }
    }

    public class CreateMedicamentosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateMedicamentosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateMedicamentosExamples : IExamplesProvider<MedicamentosDto>
    {
        public MedicamentosDto GetExamples()
        {
            return new MedicamentosDto()
            {
                medi_Id = 19,
                medi_Nombre = ""
            };
        }
    }

    public class UpdateMedicamentosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateMedicamentosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteMedicamentosExamples : IExamplesProvider<MedicamentosDto>
    {
        public MedicamentosDto GetExamples()
        {
            return new MedicamentosDto()
            {
                medi_Id = 4
            };
        }
    }

    public class DeleteMedicamentosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteMedicamentosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
