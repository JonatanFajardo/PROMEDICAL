using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListEmpleadosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Empleados_SelectDto>()
                {
                    new Empleados_SelectDto()
                    {
                        empd_Id = 25,
                        pers_Identidad = "1313194288157",
                        pers_PrimerNombre = "Denis",
                        pers_ApellidoPaterno = "Sanches",
                        carg_Descripcion = "Especialista de Cirugía Maxilofacial",
                        cons_Descripcion = "A25",
                        jorn_Descripcion = "Matutina"
                    },
                    new Empleados_SelectDto()
                    {
                        empd_Id = 26,
                        pers_Identidad = "1217198850392",
                        pers_PrimerNombre = "Derick",
                        pers_ApellidoPaterno = "Soriano",
                        carg_Descripcion = "Especialista de Cosmetología",
                        cons_Descripcion = "A26",
                        jorn_Descripcion = "Vespertina"
                    }
                }
            };
        }
    }
    #endregion

    #region Find
    public class FindEmpleadosResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Empleados_FindDto>()
                {
                    new Empleados_FindDto()
                    {
                        empd_Id = 13,
                        carg_Id = 13,
                        carg_Descripcion = "Trabajadores sociales",
                        cons_Id = 13,
                        cons_Descripcion = "A13",
                        jorn_Id = 1,
                        jorn_Descripcion = "Matutina",
                        pers_Id = 13,
                        pers_Identidad = "1613201217740",
                        pers_PrimerNombre = "Beverly",
                        pers_SegundoNombre = "Angelina",
                        pers_ApellidoPaterno = "Rápalo",
                        pers_ApellidoMaterno = "Aguilar",
                        pers_FechaNacimiento = Convert.ToDateTime("1954-01-10"),
                        pers_CorreoElectronico = "beverlyangelina653@gmail.com",
                        pers_Telefono = "99746324",
                        pers_Calle = "5589 Velvet Robin Meadow",
                        pers_Ciudad = "Lazy Lake",
                        pers_Provincia = "Alabama",
                        pers_CodigoPostal = "36753-3578",
                        pers_Pais = "US",
                        pers_Sexo = "F",
                        pers_EsActivo = true
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateEmpleadosExamples : IExamplesProvider<Empleados_CreateDto>
    {
        public Empleados_CreateDto GetExamples()
        {
            return new Empleados_CreateDto()
            {
                carg_Id = 17,
                cons_Id = 17,
                jorn_Id = 1,
                pers_Identidad = "0207202192931",
                pers_PrimerNombre = "Kathy",
                pers_SegundoNombre = "Yudi",
                pers_ApellidoPaterno = "Soriano",
                pers_ApellidoMaterno = "Diaz",
                pers_FechaNacimiento = Convert.ToDateTime("1989-06-08"),
                pers_CorreoElectronico = "kathyyudi767@gmail.com",
                pers_Telefono = "99340027",
                pers_Calle = "346 Broad Panda Campus",
                pers_Ciudad = "Big Beaver",
                pers_Provincia = "Oklahoma",
                pers_CodigoPostal = "73181-2636",
                pers_Pais = "US",
                pers_Sexo = "F",
                pers_UsuarioRegistra = 1
            };
        }
    }

    public class CreateEmpleadosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateEmpleadosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateEmpleadosExamples : IExamplesProvider<Empleados_UpdateDto>
    {
        public Empleados_UpdateDto GetExamples()
        {
            return new Empleados_UpdateDto()
            {
                    empd_Id = 34,
                    carg_Id = 34,
                    cons_Id = 6,
                    jorn_Id = 2,
                    pers_PrimerNombre = "Junior",
                    pers_SegundoNombre = "Axel",
                    pers_ApellidoPaterno = "Fajardo",
                    pers_ApellidoMaterno = "Ortez",
                    pers_FechaNacimiento = Convert.ToDateTime("2020-08-28"),
                    pers_CorreoElectronico = "junioraxel309@gmail.com",
                    pers_Telefono = "98588377",
                    pers_Calle = "4287 Easy View",
                    pers_Ciudad = "",
                    pers_Provincia = "Delaware",
                    pers_CodigoPostal = "19810-7489",
                    pers_Pais = "US",
                    pers_Sexo = "M",
                    pers_EsActivo = true,
                    pers_UsuarioModifica = 1
            };
        }
    }

    public class UpdateEmpleadosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateEmpleadosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteEmpleadosExamples : IExamplesProvider<Empleados_DeleteDto>
    {
        public Empleados_DeleteDto GetExamples()
        {
            return new Empleados_DeleteDto()
            {
                empd_Id = 758
            };
        }
    }

    public class DeleteEmpleadosOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteEmpleadosErrorResponseExamples : IExamplesProvider<ServiceResult>
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
