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
    public class PacientesRepository : IPacientesRepository
    {
        public async Task<IEnumerable<UDP_Pacientes_FindResult>> ListAsync()
        {
            const string sqlQuery = "UDP_Pacientes_Select";
            return await Transaction.SelectAsync<UDP_Pacientes_FindResult>(sqlQuery);
        }

        public async Task<UDP_Pacientes_FindResult> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Pacientes_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<UDP_Pacientes_FindResult>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbPacientes entity)
        {
            const string sqlQuery = "UDP_Pacientes_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@emps_Id", entity.emps_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tipsan_Id", entity.tipsan_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@peci_altura", entity.peci_altura, DbType.Decimal, ParameterDirection.Input);
            parameter.Add("@peci_peso", entity.peci_peso, DbType.Int32, ParameterDirection.Input);
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
        public async Task<Boolean> EditAsync(tbPacientes entity)
        {
            const string sqlQuery = "UDP_Pacientes_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", entity.paci_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@emps_Id", entity.emps_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tipsan_Id", entity.tipsan_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@peci_altura", entity.peci_altura, DbType.Decimal, ParameterDirection.Input);
            parameter.Add("@peci_peso", entity.peci_peso, DbType.Int32, ParameterDirection.Input);
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
            const string sqlQuery = "UDP_Pacientes_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
