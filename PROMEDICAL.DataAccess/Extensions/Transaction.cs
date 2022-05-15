using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                //if (result == null && result.Count() > 0)
                database.Close();
                database.Dispose();
                if (Affected(result))
                    return null;

                return result;
            }
        }

        public static async Task<IEnumerable<T>> SelectAsync<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.QueryAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                //if (result == null && result.Count() > 0)
                if (Affected(result))
                    return null;

                return result;
                //answer.ErrorGeneral = error.Message;
                //answer.ErrorDetails = error.ToString();
            }
        }

        public static async Task<Boolean> SendAsync(string sqlQuery, DynamicParameters parameters)
        {
            Boolean resultSql = true;
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.ExecuteAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                if (Affected(result))
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
                if (Affected(result))
                    return default(T);

                return result;
            }
        }

        public static async Task<Boolean> DeleteAsync(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppPromedicalDbContext.ConnectionString))
            {
                database.Open();
                int result = await database.ExecuteAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                if (Affected(result))
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Indica si se afecto una row en la base de datos.
        /// </summary>
        /// <param name="result">Valor del resultado obtenido del Execute.</param>
        /// <returns>
        /// true si el valor indicado coincide con una row afectada.
        /// </returns>
        private static Boolean Affected(int result)
        {
            if (!result.Equals(0))
                return false;

            return true;
        }

        /// <summary>
        /// Indica si se afecto una row en la base de datos.
        /// </summary>
        /// <param name="result">Valor del resultado obtenido del QueryFirstOrDefault.</param>
        /// <returns>
        /// true si el valor indicado coincide con una row afectada.
        /// </returns>
        private static Boolean Affected(object result)
        {
            //result == null && result.Count() > 0
            if (result != null)
                return false;

            return true;
        }
    }
}
