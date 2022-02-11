using Dapper;
using PROMEDICAL.DataAccess.Extensions;
using PROMEDICAL.Entities.Entities;
using PROMEDICAL.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDICAL.Logic.Repositories
{
    public class ConsultoriosRepository : IConsultoriosRepository
    {
        public async Task<IEnumerable<tbConsultorios>> ListAsync()
        {
            const string sqlQuery = "UDP_Consultorios_List";
            return await Transaction.SelectAsync<tbConsultorios>(sqlQuery);
        }
        public async Task<tbConsultorios> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Consultorios_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@cons_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbConsultorios>(sqlQuery, parameter);
        }
        public async Task<tbConsultorios> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Consultorios_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@cons_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbConsultorios>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbConsultorios entity)
        {
            entity.cons_UsuarioRegistra = 1;
            const string sqlQuery = "UDP_Consultorios_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@cons_Descripcion", entity.cons_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@cons_UsuarioRegistra", entity.cons_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbConsultorios entity)
        {
            entity.cons_UsuarioModifica = 1;
            const string sqlQuery = "UDP_Consultorios_Edit";
            var parameter = new DynamicParameters();
            parameter.Add("@cons_Id", entity.cons_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@cons_Descripcion", entity.cons_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@cons_UsuarioModifica", entity.cons_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Consultorios_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@raza_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
