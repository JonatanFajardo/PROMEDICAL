using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.DataAccess
{
    public class AppPromedicalDbContext : DbContext
    {
        //private readonly static string _connectionString = "Data Source=JOHN-EB;Initial Catalog=MEDICALSYSTEM;User ID=JonnaH;Password=admin";
        private readonly static string _connectionString = "workstation id=PROMEDICAL.mssql.somee.com;packet size=4096;user id=jonnaH000_SQLLogin_1;pwd=o22voi8691;data source=PROMEDICAL.mssql.somee.com;persist security info=False;initial catalog=PROMEDICAL";
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString()
        {
            var connString = new SqlConnectionStringBuilder()
            {
                ConnectionString = _connectionString
            };
            ConnectionString = connString.ConnectionString;
        }
    }
}
