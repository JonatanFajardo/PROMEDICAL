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
            using (var db = new SqlConnection())
            {
                db.Open();
                try
                {
                    var result = await db.QueryAsync<T>(sqlQuery, commandType: CommandType.StoredProcedure);
                    db.Close();
                    db.Dispose();
                    return result;
                }
                catch (Exception error)
                {
                    db.Close();
                    db.Dispose();
                    return null;
                }
            }
        }

        public static async Task<IEnumerable<T>> SelectAsync<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var db = new SqlConnection())
            {
                db.Open();
                try
                {
                    var result = await db.QueryAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                    db.Close();
                    db.Dispose();
                    return result;
                }
                catch (Exception error)
                {
                    db.Close();
                    db.Dispose();
                    return null;
                }
            }
        }

        public static async Task<Boolean> SendAsync(string sqlQuery, DynamicParameters parameters)
        {
            Boolean resultSql = true;
            using (var db = new SqlConnection(sqlQuery))
            {
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        await db.QueryAsync(sqlQuery, parameters, transaction, commandType: CommandType.StoredProcedure);
                        transaction.Commit();
                        db.Close();
                        db.Dispose();
                        return false;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        db.Close();
                        db.Dispose();

                        return true;
                    }
                }
            }
        }

        public static async Task<T> FindAsync<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var db = new SqlConnection(sqlQuery))
            {
                try
                {
                    var result = await db.QueryFirstOrDefaultAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                    db.Close();
                    db.Dispose();
                    return result;
                }
                catch (Exception error)
                {
                    db.Close();
                    db.Dispose();
                    return default(T);
                }
            }
        }

        public static Task<bool> DeleteAsync(string sqlQuery, DynamicParameters parameter)
        {
            throw new NotImplementedException();
        }
    }
}
