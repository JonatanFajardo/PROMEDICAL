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
    public class TipoConsultasRepository : ITipoConsultasRepository
    {
        public async Task<IEnumerable<tbTipoConsultas>> ListAsync()
        {
            const string sqlQuery = "UDP_TipoConsultas_List";
            return await Transaction.SelectAsync<tbTipoConsultas>(sqlQuery);
        }
        public async Task<tbTipoConsultas> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_TipoConsultas_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@tico_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTipoConsultas>(sqlQuery, parameter);
        }
        public async Task<tbTipoConsultas> FindAsync(int id)
        {
            const string sqlQuery = "UDP_TipoConsultas_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@tico_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbTipoConsultas>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbTipoConsultas entity)
        {
            entity.tico_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_TipoConsultas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@tico_Descripcion", entity.tico_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tico_UsuarioRegistra", entity.tico_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbTipoConsultas entity)
        {
            entity.tico_UsuarioModifica = 1;
            const string sqlQuery = "UDP_TipoConsultas_Edit";
            var parameter = new DynamicParameters();
            parameter.Add("@tico_Id", entity.tico_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tico_Descripcion", entity.tico_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@tico_UsuarioModifica", entity.tico_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_TipoConsultass_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
