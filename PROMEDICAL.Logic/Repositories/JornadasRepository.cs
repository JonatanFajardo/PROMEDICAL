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
    public class JornadasRepository : IJornadasRepository
    {
        public async Task<IEnumerable<tbJornadas>> ListAsync()
        {
            const string sqlQuery = "UDP_Jornadas_List";
            return await Transaction.SelectAsync<tbJornadas>(sqlQuery);
        }
        public async Task<tbJornadas> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Jornadas_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@jorn_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbJornadas>(sqlQuery, parameter);
        }
        public async Task<tbJornadas> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Jornadas_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@jorn_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbJornadas>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbJornadas entity)
        {
            entity.jorn_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Jornadas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@jorn_Descripcion", entity.jorn_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@jorn_UsuarioRegistra", entity.jorn_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbJornadas entity)
        {
            entity.jorn_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Jornadas_Edit";
            var parameter = new DynamicParameters();
            parameter.Add("@jorn_Id", entity.jorn_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@jorn_Descripcion", entity.jorn_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@jorn_UsuarioModifica", entity.jorn_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Jornadas_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
