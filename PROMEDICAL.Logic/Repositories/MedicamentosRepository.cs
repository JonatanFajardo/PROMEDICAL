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
    public class MedicamentosRepository : IMedicamentosRepository
    {
        public async Task<IEnumerable<tbMedicamentos>> ListAsync()
        {
            const string sqlQuery = "UDP_Medicamentos_List";
            return await Transaction.SelectAsync<tbMedicamentos>(sqlQuery);
        }
        public async Task<tbMedicamentos> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Medicamentos_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@medi_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbMedicamentos>(sqlQuery, parameter);
        }
        public async Task<tbMedicamentos> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Medicamentos_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@medi_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbMedicamentos>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbMedicamentos entity)
        {
            entity.medi_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Medicamentos_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@medi_Descripcion", entity.medi_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@medi_UsuarioRegistra", entity.medi_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbMedicamentos entity)
        {
            entity.medi_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Medicamentos_Edit";
            var parameter = new DynamicParameters();
            parameter.Add("@medi_Id", entity.medi_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@medi_Descripcion", entity.medi_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@medi_UsuarioModifica", entity.medi_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Medicamentos_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
