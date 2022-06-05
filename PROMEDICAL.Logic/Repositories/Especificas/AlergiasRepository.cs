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
    public class AlergiasRepository : IAlergiasRepository
    {
        public async Task<IEnumerable<tbAlergias>> ListAsync()
        {
            const string sqlQuery = "UDP_Alergias_Select";
            return await Transaction.SelectAsync<tbAlergias>(sqlQuery);
        }
        public async Task<tbAlergias> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Alergias_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@algi_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbAlergias>(sqlQuery, parameter);
        }
        public async Task<tbAlergias> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Alergias_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@algi_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbAlergias>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbAlergias entity)
        {
            const string sqlQuery = "UDP_Alergias_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@algi_Nombre", entity.algi_Nombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@algi_Descripcion", entity.algi_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@algi_UsuarioRegistra", entity.algi_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbAlergias entity)
        {
            const string sqlQuery = "UDP_Alergias_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@algi_Id", entity.algi_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@algi_Nombre", entity.algi_Nombre, DbType.String, ParameterDirection.Input);
            parameter.Add("@algi_Descripcion", entity.algi_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@algi_UsuarioModifica", entity.algi_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Alergias_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@algi_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
