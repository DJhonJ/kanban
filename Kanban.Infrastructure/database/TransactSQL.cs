using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Infrastructure.database
{
    public class TransactSQL
    {
        private readonly Connection connectionObj;

        public TransactSQL()
        {
            if (connectionObj == null)
            {
                connectionObj = new Connection();
            }
        }

        public ResultSQL ExecuteQuery(string nameSP, params ParameterSQL[] parameters)
        {
            if (connectionObj == null)
            {
                throw new Exception("Fallo conexion server database.");
            }

            DataSet dataset = new DataSet();

            try
            {
                using (var connection = connectionObj.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(nameSP, connection) {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            parameters.ToList().ForEach(parameter =>
                            {
                                command.Parameters.Add(new SqlParameter()
                                {
                                    ParameterName = parameter.Name,
                                    Value = parameter.Value,
                                    SqlDbType = parameter.SqlDbType,
                                    Size = parameter.Size,
                                    Direction = parameter.Direction
                                });
                            });
                        }

                        connectionObj.Open();
                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(command))
                        {
                            sqlAdapter.Fill(dataset);
                            sqlAdapter.Dispose();
                            command.Dispose();
                            connectionObj.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new ResultSQL(dataset);
        }
    }
}
