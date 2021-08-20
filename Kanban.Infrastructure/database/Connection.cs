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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SqlConnection GetConnection()
        {
            sqlConnection = new SqlConnection(GetConnectionString());
            return sqlConnection;
        }
        
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Kanban"].ConnectionString;
        }
    }
}
