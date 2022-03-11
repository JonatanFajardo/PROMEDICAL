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
    public class EmpresasRepository : IEmpresasRepository
    {
        public async Task<IEnumerable<tbEmpresas>> ListAsync()
        {
            const string sqlQuery = "UDP_Empresas_Select";
            return await Transaction.SelectAsync<tbEmpresas>(sqlQuery);
        }
        public async Task<tbEmpresas> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Empresas_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbEmpresas>(sqlQuery, parameter);
        }
        public async Task<tbEmpresas> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Empresas_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbEmpresas>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbEmpresas entity)
        {
            const string sqlQuery = "UDP_Empresas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@emps_Id", entity.emps_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@emps_RTN", entity.emps_RTN, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_NombreComercial", entity.emps_NombreComercial, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_CorreoElectronico", entity.emps_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_Telefono", entity.emps_Telefono, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_EsActivo", entity.emps_EsActivo, DbType.Boolean, ParameterDirection.Input);
            parameter.Add("@emps_UsuarioRegistra", entity.emps_UsuarioRegistra, DbType.Date, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbEmpresas entity)
        {
            const string sqlQuery = "UDP_Empresas_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@emps_Id", entity.emps_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@emps_RTN", entity.emps_RTN, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_NombreComercial", entity.emps_NombreComercial, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_CorreoElectronico", entity.emps_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_Telefono", entity.emps_Telefono, DbType.String, ParameterDirection.Input);
            parameter.Add("@emps_EsActivo", entity.emps_EsActivo, DbType.Boolean, ParameterDirection.Input);
            parameter.Add("@emps_UsuarioModifica", entity.emps_UsuarioModifica, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Empresas_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
