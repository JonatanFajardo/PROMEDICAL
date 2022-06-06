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
    public class PrescripcionesRepository : IPrescripcionesRepository
    {
        public async Task<IEnumerable<tbPrescripciones>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<tbPrescripciones>> ListAsync(int id)
        {
            const string sqlQuery = "UDP_Prescripciones_Select";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SelectAsync<tbPrescripciones>(sqlQuery, parameter);
        }

        public async Task<tbPrescripciones> DetailAsync(int id)
        {
            const string sqlQuery = "UDP_Prescripciones_Detail";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbPrescripciones>(sqlQuery, parameter);
        }
        public async Task<tbPrescripciones> FindAsync(int id)
        {
            const string sqlQuery = "UDP_Prescripciones_Find";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.FindAsync<tbPrescripciones>(sqlQuery, parameter);
        }
        public async Task<Boolean> AddAsync(tbPrescripciones entity)
        {
            const string sqlQuery = "UDP_Prescripciones_Insert";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Descripcion", entity.pres_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@pres_UsuarioRegistra", entity.pres_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> EditAsync(tbPrescripciones entity)
        {
            const string sqlQuery = "UDP_Prescripciones_Update";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Id", entity.pres_Id, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@pres_Descripcion", entity.pres_Descripcion, DbType.String, ParameterDirection.Input);
            parameter.Add("@pres_UsuarioModifica", entity.pres_UsuarioRegistra, DbType.Int32, ParameterDirection.Input);
            return await Transaction.SendAsync(sqlQuery, parameter);
        }

        public async Task<Boolean> RemoveAsync(int id)
        {
            const string sqlQuery = "UDP_Prescripciones_Delete";
            var parameter = new DynamicParameters();
            parameter.Add("@pres_Id", id, DbType.Int32, ParameterDirection.Input);
            return await Transaction.DeleteAsync(sqlQuery, parameter);
        }
    }
}
