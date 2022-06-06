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
    public class FrecuenciasCardiacasRepository : IFrecuenciasCardiacasRepository
    {
        public async Task<IEnumerable<tbFrecuenciasCardiacas>> ListAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<tbFrecuenciasCardiacas>> ListAsync(int id)
        {
            const string sqlQuery = "UDP_FrecuenciasCardiacas_Select";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SelectAsync<tbFrecuenciasCardiacas>(sqlQuery, parameter);
        }
        public async Task<tbFrecuenciasCardiacas> DetailAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<tbFrecuenciasCardiacas> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Boolean> AddAsync(tbFrecuenciasCardiacas entity)
        {
            const string sqlQuery = "UDP_FrecuenciasCardiacas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", entity.paci_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@rica_Alta", entity.rica_Alta, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@rica_Baja", entity.rica_Baja, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@rica_UsuarioRegistra", entity.rica_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbFrecuenciasCardiacas entity)
        {
            throw new NotImplementedException();
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
