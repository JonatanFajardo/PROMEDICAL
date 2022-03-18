using PROMEDICAL.Business.Dto;
using PROMEDICAL.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROMEDICAL.Business.Extensions
{
    public class MappingCustom
    {
        public static tbEmpleados Map(Empleados_CreateDto dto)
        {
            tbEmpleados empleados = new tbEmpleados()
            {
                carg_Id = dto.carg_Id,
                cons_Id = dto.cons_Id,
                jorn_Id = dto.jorn_Id,
                pers = new tbPersonas()
                {
                    pers_Identidad = dto.pers_Identidad,
                    pers_PrimerNombre = dto.pers_PrimerNombre,
                    pers_SegundoNombre = dto.pers_SegundoNombre,
                    pers_ApellidoPaterno = dto.pers_ApellidoPaterno,
                    pers_ApellidoMaterno = dto.pers_ApellidoMaterno,
                    pers_FechaNacimiento = dto.pers_FechaNacimiento,
                    pers_CorreoElectronico = dto.pers_CorreoElectronico,
                    pers_Telefono = dto.pers_Telefono,
                    pers_Calle = dto.pers_Calle,
                    pers_Ciudad = dto.pers_Ciudad,
                    pers_Provincia = dto.pers_Provincia,
                    pers_CodigoPostal = dto.pers_CodigoPostal,
                    pers_Pais = dto.pers_Pais,
                    pers_Sexo = dto.pers_Sexo,
                    pers_UsuarioRegistra = dto.pers_UsuarioRegistra
                }

            };
            return empleados;
        }

        internal static tbEmpleados Map(Empleados_UpdateDto dto)
        {
            tbEmpleados empleados = new tbEmpleados()
            {
                empd_Id = dto.empd_Id,
                carg_Id = dto.carg_Id,
                cons_Id = dto.cons_Id,
                jorn_Id = dto.jorn_Id,
                pers = new tbPersonas()
                {
                    pers_PrimerNombre = dto.pers_PrimerNombre,
                    pers_SegundoNombre = dto.pers_SegundoNombre,
                    pers_ApellidoPaterno = dto.pers_ApellidoPaterno,
                    pers_ApellidoMaterno = dto.pers_ApellidoMaterno,
                    pers_FechaNacimiento = dto.pers_FechaNacimiento,
                    pers_CorreoElectronico = dto.pers_CorreoElectronico,
                    pers_Telefono = dto.pers_Telefono,
                    pers_Calle = dto.pers_Calle,
                    pers_Ciudad = dto.pers_Ciudad,
                    pers_Provincia = dto.pers_Provincia,
                    pers_CodigoPostal = dto.pers_CodigoPostal,
                    pers_Pais = dto.pers_Pais,
                    pers_Sexo = dto.pers_Sexo,
                    pers_EsActivo = dto.pers_EsActivo,
                    pers_UsuarioModifica = dto.pers_UsuarioModifica
                }

            };
            return empleados;
        }

        internal static tbPacientes Map(Pacientes_CreateDto dto)
        {
            tbPacientes pacientes = new tbPacientes()
            {
                emps_Id = dto.emps_Id,
                tipsan_Id = dto.tipsan_Id,
                peci_altura = dto.peci_altura,
                peci_peso = dto.peci_peso,
                pers = new tbPersonas()
                {
                    pers_Identidad = dto.pers_Identidad,
                    pers_PrimerNombre = dto.pers_PrimerNombre,
                    pers_SegundoNombre = dto.pers_SegundoNombre,
                    pers_ApellidoPaterno = dto.pers_ApellidoPaterno,
                    pers_ApellidoMaterno = dto.pers_ApellidoMaterno,
                    pers_FechaNacimiento = dto.pers_FechaNacimiento,
                    pers_CorreoElectronico = dto.pers_CorreoElectronico,
                    pers_Telefono = dto.pers_Telefono,
                    pers_Calle = dto.pers_Calle,
                    pers_Ciudad = dto.pers_Ciudad,
                    pers_Provincia = dto.pers_Provincia,
                    pers_CodigoPostal = dto.pers_CodigoPostal,
                    pers_Pais = dto.pers_Pais,
                    pers_Sexo = dto.pers_Sexo,
                    pers_UsuarioRegistra = dto.pers_UsuarioRegistra
                }
            };
            return pacientes;
        }
        internal static tbPacientes Map(Pacientes_UpdateDto dto)
        {
            tbPacientes pacientes = new tbPacientes()
            {
                paci_Id = dto.paci_Id,
                emps_Id = dto.emps_Id,
                tipsan_Id = dto.tipsan_Id,
                peci_altura = dto.peci_altura,
                peci_peso = dto.peci_peso,
                pers = new tbPersonas()
                {
                    pers_PrimerNombre = dto.pers_PrimerNombre,
                    pers_SegundoNombre = dto.pers_SegundoNombre,
                    pers_ApellidoPaterno = dto.pers_ApellidoPaterno,
                    pers_ApellidoMaterno = dto.pers_ApellidoMaterno,
                    pers_FechaNacimiento = dto.pers_FechaNacimiento,
                    pers_CorreoElectronico = dto.pers_CorreoElectronico,
                    pers_Telefono = dto.pers_Telefono,
                    pers_Calle = dto.pers_Calle,
                    pers_Ciudad = dto.pers_Ciudad,
                    pers_Provincia = dto.pers_Provincia,
                    pers_CodigoPostal = dto.pers_CodigoPostal,
                    pers_Pais = dto.pers_Pais,
                    pers_Sexo = dto.pers_Sexo,
                    pers_EsActivo = dto.pers_EsActivo,
                    pers_UsuarioModifica = dto.pers_UsuarioModifica
                }
            };
            return pacientes;
        }

        internal static tbEmpresas Map(Empresas_CreateDto dto)
        {
            tbEmpresas empresas = new tbEmpresas()
            {
                emps_RTN = dto.emps_RTN,
                emps_NombreComercial = dto.emps_NombreComercial,
                emps_CorreoElectronico = dto.emps_CorreoElectronico,
                emps_Telefono = dto.emps_Telefono,
                emps_Direccion = dto.emps_Direccion,
                emps_UsuarioRegistra = dto.emps_UsuarioRegistra
            };
            return empresas;
        }

        internal static tbEmpresas Map(Empresas_UpdateDto dto)
        {
            tbEmpresas empresas = new tbEmpresas()
            {
                emps_Id = dto.emps_Id,
                emps_NombreComercial = dto.emps_NombreComercial,
                emps_CorreoElectronico = dto.emps_CorreoElectronico,
                emps_Telefono = dto.emps_Telefono,
                emps_Direccion = dto.emps_Direccion,
                emps_EsActivo = dto.emps_EsActivo,
                emps_UsuarioModifica = dto.emps_UsuarioModifica
            };
            return empresas;
        }

        

        //public static void Map(Empleados_CreateDto dto)
        //{

        //}


    }
}
