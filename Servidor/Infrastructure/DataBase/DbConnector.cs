using System.Data;
using System.Data.SqlClient;

namespace Servidor.Infrastructure.DataBase
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;

        public DbConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var _conexion = _configuration.GetConnectionString("DefaultConnection");
            return new SqlConnection(_conexion);
        }
    }
}
