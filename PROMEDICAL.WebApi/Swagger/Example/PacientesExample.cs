using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListPacientesResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Pacientes_SelectDto>()
                {
                    new Pacientes_SelectDto()
                    {
                        paci_Id = 14,
                        pers_Identidad = "1219200311732",
                        pers_PrimerNombre = "Geovanny",
                        pers_ApellidoPaterno = "Fuente",
                        peci_altura = 195,
                        peci_peso = 111,
                        emps_NombreComercial = "shofay",
                        emps_RTN = "12234681788846",
                        emps_Telefono = "99241373"
                    },
                    new Pacientes_SelectDto()
                    {
                        paci_Id = 13,
                        pers_Identidad = "0901195445786",
                        pers_PrimerNombre = "Krizia",
                        pers_ApellidoPaterno = "Villeda",
                        peci_altura = 161,
                        peci_peso = 227,
                        emps_NombreComercial = "shofay",
                        emps_RTN = "12234681788846",
                        emps_Telefono = "99241373"
                    }
                }
            };
        }
    }
    #endregion

    #region Find
    public class FindPacientesResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Pacientes_FindDto>()
                {
                    new Pacientes_FindDto()
                    {
                        paci_Id = 18,
                        pers_Id = 66,
                        emps_Id = 2,
                        tipsan_Id = 6,
                        peci_altura = "AB-",
                        peci_peso = 77,
                        pers_Identidad = "1305194027261",
                        pers_PrimerNombre = "Bryan",
                        pers_SegundoNombre = "Noel",
                        pers_ApellidoPaterno = "Perez",
                        pers_ApellidoMaterno = "Estarlin",
                        pers_FechaNacimiento = Convert.ToDateTime("2015-12-18"),
                        pers_CorreoElectronico = "bryannoel757@gmail.com",
                        pers_Telefono = "98540834",
                        pers_Calle = "7994 Broad Mount",
                        pers_Ciudad = "",
                        pers_Provincia = "Utah",
                        pers_CodigoPostal = "84558-3992",
                        pers_Pais = "US",
                        pers_Sexo = "M",
                        pers_EsActivo = true,
                        emps_NombreComercial = "reinu",
                        emps_RTN = "77264101904693",
                        emps_CorreoElectronico = "reinu@gmail.com",
                        emps_Telefono = "99871246",
                        emps_Direccion = "Buena Vista",
                        emps_EsActivo = true
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreatePacientesExamples : IExamplesProvider<Pacientes_CreateDto>
    {
        public Pacientes_CreateDto GetExamples()
        {
            return new Pacientes_CreateDto()
            {
                emps_Id = 2,
                tipsan_Id = 8,
                peci_altura = Convert.ToInt32(1.83),
                peci_peso = 118,
                pers_Identidad = "0304202035535",
                pers_PrimerNombre = "Adrian",
                pers_SegundoNombre = "Noan",
                pers_ApellidoPaterno = "Nicole",
                pers_ApellidoMaterno = "Hernández",
                pers_FechaNacimiento = Convert.ToDateTime("1959-06-17"),
                pers_CorreoElectronico = "adriannoan31@gmail.com",
                pers_Telefono = "98480642",
                pers_Calle = "7429 Dewy Rise Meadow",
                pers_Ciudad = "",
                pers_Provincia = "Connecticut",
                pers_CodigoPostal = "06984-5448",
                pers_Pais = "US",
                pers_Sexo = "M",
                pers_UsuarioRegistra = 1
            };
        }
    }

    public class CreatePacientesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreatePacientesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdatePacientesExamples : IExamplesProvider<Pacientes_UpdateDto>
    {
        public Pacientes_UpdateDto GetExamples()
        {
            return new Pacientes_UpdateDto()
            {
                paci_Id = 32,
                emps_Id = 2,
                tipsan_Id = 2,
                peci_altura = 1.83M,
                peci_peso = 202,
                pers_PrimerNombre = "Marlon",
                pers_SegundoNombre = "Antony",
                pers_ApellidoPaterno = "Fernandez",
                pers_ApellidoMaterno = "Flores",
                pers_FechaNacimiento = Convert.ToDateTime("1949-03-09"),
                pers_CorreoElectronico = "marlonantony871@gmail.com",
                pers_Telefono = "33266496",
                pers_Calle = "1254 High Cider Highway",
                pers_Ciudad = "",
                pers_Provincia = "Quebec",
                pers_CodigoPostal = "J0B-5U2",
                pers_Pais = "CA",
                pers_Sexo = "M",
                pers_EsActivo = true,
            };
        }
    }

    public class UpdatePacientesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdatePacientesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeletePacientesExamples : IExamplesProvider<Pacientes_DeleteDto>
    {
        public Pacientes_DeleteDto GetExamples()
        {
            return new Pacientes_DeleteDto()
            {
                paci_Id = 758
            };
        }
    }

    public class DeletePacientesOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeletePacientesErrorResponseExamples : IExamplesProvider<ServiceResult>
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
