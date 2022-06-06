using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListCitasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<CitasSelectDto>()
                {
                    new CitasSelectDto()
                    {
                        cita_Id = 5,
                        paci_Id = 5,
                        paci_PrimerNombre = "Jency",
                        paci_ApellidoPaterno = "Hernandez",
                        empd_Id = 47,
                        empd_PrimerNombre = "Lizbeth",
                        empd_ApellidoPaterno = "Vanss",
                        tici_Id = 1,
                        tici_Descripcion = "Consulta",
                        cita_FechaCita = Convert.ToDateTime("2017-07-20"),
                        cita_UsuarioRegistra = 0,
                        cita_FechaRegistra = Convert.ToDateTime("2022-03-08"),
                        cita_UsuarioModifica = null,
                        cita_FechaModifica = null
                    },
                    new CitasSelectDto()
                    {
                        cita_Id = 6,
                        paci_Id = 6,
                        paci_PrimerNombre = "Marcio",
                        paci_ApellidoPaterno = "Benítez",
                        empd_Id = 29,
                        empd_PrimerNombre = "Denis",
                        empd_ApellidoPaterno = "Colindres",
                        tici_Id = 2,
                        tici_Descripcion = "Cita Programada",
                        cita_FechaCita = Convert.ToDateTime("2015-08-14"),
                        cita_UsuarioRegistra = 0,
                        cita_FechaRegistra = Convert.ToDateTime("2022-03-08"),
                        cita_UsuarioModifica = 1,
                        cita_FechaModifica = Convert.ToDateTime("2023-02-08")
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateCitasExamples : IExamplesProvider<CitasCreateDto>
    {
        public CitasCreateDto GetExamples()
        {
            return new CitasCreateDto()
            {
                paci_Id = 3,
                empd_Id = 44,
                tici_Id = 2,
                cita_FechaCita = Convert.ToDateTime("2020-07-17"),
                pers_UsuarioRegistra = 1
            };
        }
    }

    public class CreateCitasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateCitasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
