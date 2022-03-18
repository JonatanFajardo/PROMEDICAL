using PROMEDICAL.Business.Dto;
using PROMEDICAL.Business.Extensions;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace PROMEDICAL.WebApi.Swagger.Example
{
    #region List
    public class ListEmpresasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Empresas_SelectDto>()
                {
                    new Empresas_SelectDto()
                    {
                        emps_Id = 2,
                        emps_RTN = "77264101904693",
                        emps_NombreComercial = "reinu",
                        emps_CorreoElectronico = "reinu@gmail.com",
                        emps_Telefono = "99871246",
                        emps_Direccion = "Buena Vista",
                        emps_EsActivo = true
                    },
                    new Empresas_SelectDto()
                    {
                        emps_Id = 3,
                        emps_RTN = "21250125618780",
                        emps_NombreComercial = "mice",
                        emps_CorreoElectronico = "mice@gmail.com",
                        emps_Telefono = "99412362",
                        emps_Direccion = "Plaza Marte",
                        emps_EsActivo = true
                    }
                }
            };
        }
    }
    #endregion

    #region Find
    public class FindEmpresasResponseExamples : IExamplesProvider<ServiceResult>
    {
        public ServiceResult GetExamples()
        {
            return new ServiceResult()
            {
                Message = "Operacion completada exitosamente",
                Success = true,
                Type = ServiceResultType.Success,
                Data = new List<Empresas_FindDto>()
                {
                    new Empresas_FindDto()
                    {
                        emps_Id = 3,
                        emps_RTN = "21250125618780",
                        emps_NombreComercial = "mice",
                        emps_CorreoElectronico = "mice@gmail.com",
                        emps_Telefono = "99412362",
                        emps_Direccion = "Plaza Marte",
                        emps_EsActivo = true,
                        emps_UsuarioRegistra = 1,
                        emps_UsuarioModifica = 1
                    }
                }
            };
        }
    }
    #endregion

    #region Create
    public class CreateEmpresasExamples : IExamplesProvider<Empresas_CreateDto>
    {
        public Empresas_CreateDto GetExamples()
        {
            return new Empresas_CreateDto()
            {
                emps_RTN = "21250125618780",
                emps_NombreComercial = "mice",
                emps_CorreoElectronico = "mice@gmail.com",
                emps_Telefono = "99412362",
                emps_Direccion = "Plaza Marte",
                emps_UsuarioRegistra = 1,
            };
        }
    }

    public class CreateEmpresasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class CreateEmpresasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class UpdateEmpresasExamples : IExamplesProvider<Empresas_UpdateDto>
    {
        public Empresas_UpdateDto GetExamples()
        {
            return new Empresas_UpdateDto()
            {
                emps_Id = 3,
                emps_NombreComercial = "mice",
                emps_CorreoElectronico = "mice@gmail.com",
                emps_Telefono = "99412362",
                emps_Direccion = "Plaza Marte",
                emps_EsActivo = true,
                emps_UsuarioModifica = 1
            };
        }
    }

    public class UpdateEmpresasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class UpdateEmpresasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
    public class DeleteEmpresasExamples : IExamplesProvider<Empresas_DeleteDto>
    {
        public Empresas_DeleteDto GetExamples()
        {
            return new Empresas_DeleteDto()
            {
                empd_Id = 758
            };
        }
    }

    public class DeleteEmpresasOKResponseExamples : IExamplesProvider<ServiceResult>
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

    public class DeleteEmpresasErrorResponseExamples : IExamplesProvider<ServiceResult>
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
