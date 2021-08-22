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

        public ResultSQL ExecuteQuery(string storeProcedure, params ParameterSQL[] parametersSQL)
        {
            if (connectionObj == null)
            {
                throw new Exception("Fallo conexion server database.");
            }

            DataSet dataset = new DataSet();

            try
            {
                using (SqlCommand command = PrepareSqlCommand(storeProcedure, connectionObj, parametersSQL))
                {
                    connectionObj.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(command))
                    {
                        sqlAdapter.Fill(dataset);
                        sqlAdapter.Dispose();
                    }

                    SaveTrace(connectionObj, command);
                    command.Dispose();
                    connectionObj.Close();
                }
            }
            catch (Exception ex)
            {
                connectionObj.Close();
                SaveLog(ex.Message);
                throw ex;
            }

            return new ResultSQL(dataset);
        }

        public void SaveLog(string query)
        {
            using (SqlCommand command = PrepareSqlCommand("GuardarLog", connectionObj, new ParameterSQL("query", query, SqlDbType.VarChar, -1)))
            {
                connectionObj.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connectionObj.Close();
            }
        }

        private void SaveTrace(Connection connection, SqlCommand commandTrace)
        {
            ParameterSQL[] parameterSQLs = new ParameterSQL[] {
                new ParameterSQL("query", CreateTrace(commandTrace), SqlDbType.VarChar, -1),
                new ParameterSQL("id_usuario", 0, SqlDbType.Int)
            };

            using (SqlCommand _command = PrepareSqlCommand("GuardarLog", connection, parameterSQLs))
            {
                _command.ExecuteNonQuery();
            }
        }

        private SqlCommand PrepareSqlCommand(string storeProcedure, Connection connection, params ParameterSQL[] parameters)
        {
            SqlCommand command = new SqlCommand(storeProcedure, connection.GetConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parameters != null && parameters.Length > 0)
            {
                parameters.ToList().ForEach(parameter =>
                {
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = $"@{parameter.Name}",
                        Value = parameter.Value,
                        SqlDbType = parameter.SqlDbType,
                        Size = parameter.Size,
                        Direction = parameter.Direction
                    });
                });
            }

            return command;
        }

        private string CreateTrace(SqlCommand command)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"exec {command.CommandText} ");
            int i = 1;
            command.Parameters.Cast<SqlParameter>().ToList().ForEach(
                param =>
                {
                    switch (param.SqlDbType)
                    {
                        case SqlDbType.Int:
                        case SqlDbType.Decimal:
                        case SqlDbType.BigInt:
                        case SqlDbType.SmallInt:
                        case SqlDbType.TinyInt:
                        case SqlDbType.Money:
                            query.Append($"{param.ParameterName} = {param.Value}");
                            break;
                        default:
                            query.Append($"{param.ParameterName} = '{param.Value}'");
                            break;
                    }
                    if (i < command.Parameters.Count) query.Append(",");
                    i++;
                }
            );

            return query.ToString();
        }
    }
}