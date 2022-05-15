using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListFrecuenciasCardiacasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<FrecuenciasCardiacas_SelectDto>()
                {
                    new FrecuenciasCardiacas_SelectDto()
                    {
                        rica_Id = 383,
                        rica_Alta = 126,
                        rica_Baja = 104,
                        rica_UsuarioRegistra = 1,
                        rica_FechaRegistra = Convert.ToDateTime("16-03-2022"),
                        rica_UsuarioModifica = 1,
                        rica_FechaModifica = Convert.ToDateTime("16-03-2022")
                    },
                    new FrecuenciasCardiacas_SelectDto()
                    {
                        rica_Id = 15,
                        rica_Alta = 151,
                        rica_Baja = 126,
                        rica_UsuarioRegistra = 1,
                        rica_FechaRegistra = Convert.ToDateTime("16-03-2022"),
                        rica_UsuarioModifica = 1,
                        rica_FechaModifica = Convert.ToDateTime("16-03-2022")
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateFrecuenciasCardiacasExamples : IExamplesProvider<FrecuenciasCardiacas_CreateDto>
    {
        public FrecuenciasCardiacas_CreateDto GetExamples()
        {
            return new FrecuenciasCardiacas_CreateDto()
            {
                paci_Id = 42,
                rica_Alta = 160,
                rica_Baja = 130,
                rica_UsuarioRegistra = 1,
            };
        }
    }

    public class CreateFrecuenciasCardiacasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateFrecuenciasCardiacasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateFrecuenciasCardiacasExamples : IExamplesProvider<FrecuenciasCardiacas_UpdateDto>
    {
        public FrecuenciasCardiacas_UpdateDto GetExamples()
        {
            return new FrecuenciasCardiacas_UpdateDto()
            {
                rica_Id = 491,
                paci_Id = 23,
                rica_Alta = 150,
                rica_Baja = 122,
                rica_UsuarioModifica = 1,
            };
        }
    }

    public class UpdateFrecuenciasCardiacasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateFrecuenciasCardiacasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteFrecuenciasCardiacasExamples : IExamplesProvider<FrecuenciasCardiacas_DeleteDto>
    {
        public FrecuenciasCardiacas_DeleteDto GetExamples()
        {
            return new FrecuenciasCardiacas_DeleteDto()
            {
                rica_Id = 758
            };
        }
    }

    public class DeleteFrecuenciasCardiacasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteFrecuenciasCardiacasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
