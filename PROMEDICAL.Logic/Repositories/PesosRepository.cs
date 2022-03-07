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
    public class PesosRepository : IPesosRepository
    {
        public async Task<IEnumerable<tbPesos>> ListAsync()
        {
            const string sqlQuery = "UDP_Pesos_Select";
            return await Transaction.SelectAsync<tbPesos>(sqlQuery);
        }
        public async Task<tbPesos> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Pesos_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@peso_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbPesos>(sqlQuery, parameter);
        }
        public async Task<tbPesos> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Pesos_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@peso_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbPesos>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbPesos entity)
        {
            entity.peso_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Pesos_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@peso_Descripcion", entity.peso_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@peso_UsuarioRegistra", entity.peso_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbPesos entity)
        {
            entity.peso_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Pesos_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@peso_Id", entity.peso_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@peso_Descripcion", entity.peso_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@peso_UsuarioModifica", entity.peso_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Pesos_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@peso_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
