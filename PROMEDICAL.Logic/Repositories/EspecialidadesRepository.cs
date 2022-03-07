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
    public class EspecialidadesRepository : IEspecialidadesRepository
    {

        public async Task<IEnumerable<tbEspecialidades>> ListAsync()
        {
            const string sqlQuery = "UDP_Especialidades_Select";
            return await Transaction.SelectAsync<tbEspecialidades>(sqlQuery);
        }
        public async Task<tbEspecialidades> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Especialidades_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@espc_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbEspecialidades>(sqlQuery, parameter);
        }
        public async Task<tbEspecialidades> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Especialidades_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@espc_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbEspecialidades>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbEspecialidades entity)
        {
            entity.espc_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Especialidades_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@espc_Descripcion", entity.espc_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@espc_UsuarioRegistra", entity.espc_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbEspecialidades entity)
        {
            entity.espc_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Especialidades_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@espc_Id", entity.espc_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@espc_Descripcion", entity.espc_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@espc_UsuarioModifica", entity.espc_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Especialidades_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@espc_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
