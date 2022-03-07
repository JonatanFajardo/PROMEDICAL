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
    public class TipoCitasRepository : ITipoCitasRepository
    {
        public async Task<IEnumerable<tbTipoCitas>> ListAsync()
        {
            const string sqlQuery = "UDP_TipoCitas_Select";
            return await Transaction.SelectAsync<tbTipoCitas>(sqlQuery);
        }
        public async Task<tbTipoCitas> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_TipoCitas_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@tici_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTipoCitas>(sqlQuery, parameter);
        }
        public async Task<tbTipoCitas> FindAsync(int id)
        {
            const string sqlQuery = "UDP_TipoCitas_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@tici_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTipoCitas>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbTipoCitas entity)
        {
            entity.tici_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_TipoCitas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@tici_Descripcion", entity.tici_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tici_UsuarioRegistra", entity.tici_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbTipoCitas entity)
        {
            entity.tici_UsuarioModifica = 1;
            const string sqlQuery = "UDP_TipoCitas_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@tici_Id", entity.tici_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tici_Descripcion", entity.tici_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tici_UsuarioModifica", entity.tici_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_TipoCitas_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@tici_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
