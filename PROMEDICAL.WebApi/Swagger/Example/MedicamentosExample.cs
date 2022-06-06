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
                Data = new List<MedicamentosSelectDto>()
                {
                    new MedicamentosSelectDto()
                    {
                        medi_Id = 854,
                        medi_Nombre = "BRONCOPULMIN GOTAS X 30 ML",
                        medi_Precio = 34,
                        medi_Descripcion = "Este producto no requiere refrigeración."
                    },
                    new MedicamentosSelectDto()
                    {
                        medi_Id = 635,
                        medi_Nombre = "BRONCOPULMIN JARABE X 120 ML",
                        medi_Precio = 34,
                        medi_Descripcion = "Este producto no requiere refrigeración."
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateMedicamentosExamples : IExamplesProvider<MedicamentosCreateDto>
    {
        public MedicamentosCreateDto GetExamples()
        {
            return new MedicamentosCreateDto()
            {
                medi_Nombre = "BORBALAN GOTAS X 30 M",
                medi_Precio = 34,
                medi_Descripcion = "Este producto no requiere refrigeración."

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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Update
    public class UpdateMedicamentosExamples : IExamplesProvider<MedicamentosUpdateDto>
    {
        public MedicamentosUpdateDto GetExamples()
        {
            return new MedicamentosUpdateDto()
            {
                medi_Id = 19,
                medi_Nombre = "BORBALAN JARABE X 120 ML",
                medi_Precio = 34,
                medi_Descripcion = "Este producto no requiere refrigeración."
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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion

    #region Delete
    public class DeleteMedicamentosExamples : IExamplesProvider<MedicamentosDeleteDto>
    {
        public MedicamentosDeleteDto GetExamples()
        {
            return new MedicamentosDeleteDto()
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
                Message = "Se ha producido un error al procesar la solicitud. Si el problema persiste, comuníquese con el administrador del sistema.",
                Success = false,
                Type = ServiceResultType.Error,
                Data = null
            };
        }
    }
    #endregion
}
