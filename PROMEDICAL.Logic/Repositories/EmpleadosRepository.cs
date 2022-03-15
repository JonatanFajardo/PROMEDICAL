using Dapper;
using PROMEDICAL.DataAccess.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces.Especific;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Repositories
{
    public class EmpleadosRepository : IEmpleadosRepository
    {
        public async Task<IEnumerable<UDP_Empleados_FindResult>> ListAsync()
        {
            const string sqlQuery = "UDP_Empleados_Select";
            return await Transaction.SelectAsync<UDP_Empleados_FindResult>(sqlQuery);
        }

        public async Task<UDP_Empleados_FindResult> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Empleados_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@empd_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<UDP_Empleados_FindResult>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbEmpleados entity)
        {
            const string sqlQuery = "UDP_Empleados_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", entity.carg_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@cons_Id", entity.cons_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@jorn_Id", entity.jorn_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@pers_Identidad", entity.pers.pers_Identidad, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_PrimerNombre", entity.pers.pers_PrimerNombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_SegundoNombre", entity.pers.pers_SegundoNombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_ApellidoPaterno", entity.pers.pers_ApellidoPaterno, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_ApellidoMaterno", entity.pers.pers_ApellidoMaterno, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_FechaNacimiento", entity.pers.pers_FechaNacimiento, DbType.Date, ParameterDirection.Input);
            parameter.Add("@pers_CorreoElectronico", entity.pers.pers_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Telefono", entity.pers.pers_Telefono, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Calle", entity.pers.pers_Calle, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Ciudad", entity.pers.pers_Ciudad, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Provincia", entity.pers.pers_Provincia, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_CodigoPostal", entity.pers.pers_CodigoPostal, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Pais", entity.pers.pers_Pais, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Sexo", entity.pers.pers_Sexo, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_UsuarioRegistra", entity.pers.pers_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbEmpleados entity)
        {
            const string sqlQuery = "UDP_Empleados_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@empd_Id", entity.empd_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@carg_Id", entity.carg_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@cons_Id", entity.cons_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@jorn_Id", entity.jorn_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@pers_PrimerNombre", entity.pers.pers_PrimerNombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_SegundoNombre", entity.pers.pers_SegundoNombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_ApellidoPaterno", entity.pers.pers_ApellidoPaterno, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_ApellidoMaterno", entity.pers.pers_ApellidoMaterno, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_FechaNacimiento", entity.pers.pers_FechaNacimiento, DbType.Date, ParameterDirection.Input);
            parameter.Add("@pers_CorreoElectronico", entity.pers.pers_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Telefono", entity.pers.pers_Telefono, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Calle", entity.pers.pers_Calle, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Ciudad", entity.pers.pers_Ciudad, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Provincia", entity.pers.pers_Provincia, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_CodigoPostal", entity.pers.pers_CodigoPostal, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Pais", entity.pers.pers_Pais, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_Sexo", entity.pers.pers_Sexo, DbType.String, ParameterDirection.Input);
            parameter.Add("@pers_EsActivo", entity.pers.pers_EsActivo, DbType.Boolean, ParameterDirection.Input);
            parameter.Add("@pers_UsuarioModifica", entity.pers.pers_UsuarioModifica, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Empleados_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@empd_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
