using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PROMEDICAL.DataAccess
{
    public class AppPromedicalDbContext : DbContext
    {
        //private readonly static string _connectionString = "Data Source=;Initial Catalog=MEDICALSYSTEM;User ID=JonnaH;Password=admin";
        private readonly static string _connectionString = "Data source = { { } }; Initial Catalog = MEDICALSYSTEM; Persist Security Info=True; User ID = JonnaH; Password=admin;";
        //private readonly static string _connectionString = "workstation id=PROMEDICAL.mssql.somee.com;packet size=4096;user id=;pwd=;data source=PROMEDICAL.mssql.somee.com;persist security info=False;initial catalog=PROMEDICAL";
        public static string ConnectionString { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string cone)
        {
            var connString = new SqlConnectionStringBuilder()
            {
                ConnectionString = cone
            };
            ConnectionString = connString.ConnectionString;
        }
    }
}
