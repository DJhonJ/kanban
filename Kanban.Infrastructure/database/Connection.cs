using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Infrastructure.database
{
    public class Connection: IDisposable
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = "";

        public void Dispose()
        {
            sqlConnection = null;
        }

        public SqlConnection GetConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(GetConnectionString());
            }

            return sqlConnection;
        }

        string GetConnectionString()
        {
            return connectionString;
            //string s = ConfigurationManager.ConnectionStrings["Kanban"].Name;
            //return s;
        }

        public void Open()
        {
            if (sqlConnection == null) throw new Exception("fallo al abrir conexion.");
            sqlConnection.Open();
        }

        public void Close()
        {
            if (sqlConnection == null) throw new Exception("fallo al cerrar conexion.");
            sqlConnection.Close();
            Dispose();
        }
    }
}
