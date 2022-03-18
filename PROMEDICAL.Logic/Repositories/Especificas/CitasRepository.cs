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
    public class CitasRepository : ICitasRepository
    {
        public async Task<IEnumerable<UDP_Citas_SelectResult>> ListAsync()
        {
            const string sqlQuery = "UDP_Citas_Select";
            return await Transaction.SelectAsync<UDP_Citas_SelectResult>(sqlQuery);
        }

        public async Task<UDP_Citas_SelectResult> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UDP_Citas_SelectResult> DetailAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Boolean> AddAsync(tbCitas entity)
        {
            const string sqlQuery = "UDP_Citas_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@paci_Id", entity.paci_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@empd_Id", entity.empd_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@tici_Id", entity.tici_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@cita_FechaCita", entity.cita_FechaCita, DbType.Date, ParameterDirection.Input);
            parameter.Add("@cita_UsuarioRegistra", entity.cita_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);

            return await Transaction.SendAsync(sqlQuery, parameter);
        }
        public async Task<Boolean> EditAsync(tbCitas entity)
        {
            throw new NotImplementedException();
        }
        public async Task<Boolean> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
