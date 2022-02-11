using Dapper;
using PROMEDICAL.DataAccess.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Repositories
{
    public class CargosRepository : ICargosRepository
    {
        public async Task<IEnumerable<tbCargos>> ListAsync()
        {
            const string sqlQuery = "UDP_Cargos_List";
            return await Transaction.SelectAsync<tbCargos>(sqlQuery);
        }
        public async Task<tbCargos> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Cargos_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbCargos>(sqlQuery, parameter);
        }
        public async Task<tbCargos> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Cargos_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbCargos>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbCargos entity)
        {
            entity.carg_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Cargos_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Descripcion", entity.carg_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@carg_UsuarioRegistra", entity.carg_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbCargos entity)
        {
            entity.carg_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Cargos_Edit";
            var parameter = new DynamicParameters();
            parameter.Add("@carg_Id", entity.carg_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@carg_Descripcion", entity.carg_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@carg_UsuarioModifica", entity.carg_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Cargos_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
