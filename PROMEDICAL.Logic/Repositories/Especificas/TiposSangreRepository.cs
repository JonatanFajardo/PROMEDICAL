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
    public class TiposSangreRepository : ITiposSangreRepository
    {

        public async Task<IEnumerable<tbTiposSangre>> ListAsync()
        {
            const string sqlQuery = "UDP_TiposSangre_Select";
            return await Transaction.SelectAsync<tbTiposSangre>(sqlQuery);
        }
        public async Task<tbTiposSangre> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_TiposSangre_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@tipsan_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTiposSangre>(sqlQuery, parameter);
        }
        public async Task<tbTiposSangre> FindAsync(int id)
        {
            const string sqlQuery = "UDP_TiposSangre_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@tipsan_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTiposSangre>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbTiposSangre entity)
        {
            const string sqlQuery = "UDP_TiposSangre_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@tipsan_Descripcion", entity.tipsan_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tipsan_UsuarioRegistra", entity.tipsan_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbTiposSangre entity)
        {
            const string sqlQuery = "UDP_TiposSangre_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@tipsan_Id", entity.tipsan_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tipsan_Descripcion", entity.tipsan_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tipsan_UsuarioModifica", entity.tipsan_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_TiposSangre_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@tipsan_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
