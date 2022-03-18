using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.DataAccess
{
    public class AppPromedicalDbContext : DbContext
    {
        private readonly static string _connectionString = "Data Source=JOHN-EB;Initial Catalog=MEDICALSYSTEM;User ID=JonnaH;Password=admin";
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string connectionString)
        {
            var connString = new SqlConnectionStringBuilder()
            {
                ConnectionString = _connectionString
            };
            ConnectionString = connString.ConnectionString;
        }
    }
}
