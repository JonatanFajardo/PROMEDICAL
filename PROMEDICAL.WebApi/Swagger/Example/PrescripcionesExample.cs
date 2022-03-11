using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using PROMEDICAL.Entities.Entities;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListPrescripcionesResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<PrescripcionesDto>()
                {
                    new PrescripcionesDto()
                    {
                        pres_Id = 796,
                        medi_Id = 644,
                        pres_Descripcion =    ""
                    },
                    new PrescripcionesDto()
                    {
                        pres_Id = 659,
                        medi_Id = 215,
                        pres_Descripcion =    ""
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreatePrescripcionesExamples : IExamplesProvider<PrescripcionesDto>
    {
        public PrescripcionesDto GetExamples()
        {
            return new PrescripcionesDto()
            {
                pres_Id = 939,
                medi_Id = 817,
                pres_Descripcion = ""
            };
        }
    }

    public class CreatePrescripcionesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreatePrescripcionesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdatePrescripcionesExamples : IExamplesProvider<PrescripcionesDto>
    {
        public PrescripcionesDto GetExamples()
        {
            return new PrescripcionesDto()
            {
                pres_Id = 63,
                medi_Id = 189,
                pres_Descripcion = ""
            };
        }
    }

    public class UpdatePrescripcionesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdatePrescripcionesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeletePrescripcionesExamples : IExamplesProvider<PrescripcionesDto>
    {
        public PrescripcionesDto GetExamples()
        {
            return new PrescripcionesDto()
            {
                pres_Id = 832
            };
        }
    }

    public class DeletePrescripcionesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeletePrescripcionesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
