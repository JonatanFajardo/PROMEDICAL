using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PROMEDICAL.DataAccess.Extensions
{
    public class Transaction
    {
        public static async Task<IEnumerable<T>> SelectAsync<T>(string sqlQuery)
        {
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                var result = await database.QueryAsync<T>(sqlQuery, commandType: CommandType.StoredProcedure);
                if (result == null && result.Count() > 0)
                {
                }
                database.Close();
                database.Dispose();
                return result;
            }
        }

        public static async Task<IEnumerable<T>> SelectAsync<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.QueryAsync<T>(sqlQuery, commandType: CommandType.StoredProcedure);
                if (result == null && result.Count() > 0)
                {
                }
                database.Close();
                database.Dispose();
                return result;
                //answer.ErrorGeneral = error.Message;
                //answer.ErrorDetails = error.ToString();
                database.Close();
                database.Dispose();
                return null;
            }
        }

        public static async Task<Boolean> SendAsync(string sqlQuery, DynamicParameters parameters)
        {
            Boolean resultSql = true;
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.QueryAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                if (result.Count() != 0)
                    return true;
                
                return false;
            }
        }

        public static async Task<T> FindAsync<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                var result = await database.QueryFirstOrDefaultAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                return result;
            }
        }

        public static Task<bool> DeleteAsync(string sqlQuery, DynamicParameters parameter)
        {
            throw new NotImplementedException();
        }
    }
}
