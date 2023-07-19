using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace WinApp.Core
{
    public class DatabaseConnection
    {
        private string _connectionString;

        public DatabaseConnection()
        {
            _connectionString = "Server=UY1-07\\SQLEXPRESS; Database=StokTakip; Trusted_Connection=True;";
        }

        public IDbConnection GetConnection
        {
            get
            {
               SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(_connectionString);
                builder.TrustServerCertificate = true;

                IDbConnection connection = new SqlConnection(builder.ToString());
                connection.Open();
                return connection;

            }
        }

    }

}
//Encrypt = Verileri şifreler
