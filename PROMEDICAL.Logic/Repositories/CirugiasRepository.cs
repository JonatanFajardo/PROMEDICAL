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
    public class CirugiasRepository : ICirugiasRepository
    {
        public async Task<IEnumerable<tbCirugias>> ListAsync()
        {
            const string sqlQuery = "UDP_Cirugias_Select";
            return await Transaction.SelectAsync<tbCirugias>(sqlQuery);
        }
        public async Task<tbCirugias> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Cirugias_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@ciru_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbCirugias>(sqlQuery, parameter);
        }
        public async Task<tbCirugias> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Cirugias_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@ciru_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbCirugias>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbCirugias entity)
        {
            entity.ciru_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Cirugias_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@ciru_Descripcion", entity.ciru_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@ciru_UsuarioRegistra", entity.ciru_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbCirugias entity)
        {
            entity.ciru_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Cirugias_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@ciru_Id", entity.ciru_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@ciru_Descripcion", entity.ciru_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@ciru_UsuarioModifica", entity.ciru_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Cirugias_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@ciru_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
