using Microsoft.Data.SqlClient;
using System.Data;

namespace ECommerce_BigDataAnalytics.Context
{
    public class AppDbContext
    {
        private readonly string _connectionString;

        public AppDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SqlConnection");
        }


        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}
