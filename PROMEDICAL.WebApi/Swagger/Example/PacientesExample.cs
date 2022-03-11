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
                        
                    },
                    new Pacientes_SelectDto()
                    {
                       
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
                Data = new List<Pacientes_SelectDto>()
                {
                    new Pacientes_SelectDto()
                    {
                        
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
                //carg_Id = 17,
                //cons_Id = 17,
                //jorn_Id = 1,
                //pers_Identidad = "0207202192931",
                //pers_PrimerNombre = "Kathy",
                //pers_SegundoNombre = "Yudi",
                //pers_ApellidoPaterno = "Soriano",
                //pers_ApellidoMaterno = "Diaz",
                //pers_FechaNacimiento = Convert.ToDateTime("1989-06-08"),
                //pers_CorreoElectronico = "kathyyudi767@gmail.com",
                //pers_Telefono = "99340027",
                //pers_Calle = "346 Broad Panda Campus",
                //pers_Ciudad = "Big Beaver",
                //pers_Provincia = "Oklahoma",
                //pers_CodigoPostal = "73181-2636",
                //pers_Pais = "US",
                //pers_Sexo = "F",
                //pers_UsuarioRegistra = 1
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
