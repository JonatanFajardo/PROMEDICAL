using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace PROMEDICAL.DataAccess
{
    public class AppPromedicalDbContext : DbContext
    {
        public static string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string connectionString)
        {
            var connString = new SqlConnectionStringBuilder()
            {
                ConnectionString = connectionString
            };
            ConnectionString = connString.ConnectionString;
        }
    }
}
