using Kanban.Data.datasource;
using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Infrastructure.database
{
    public class UserData: ILocalDataUser
    {
        private const string NAME_SP = "GestionUsuario";

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>()
            {
                //new User(1, "jhon.doe", "123456"),
                //new User(2, "emma.doe", "123456"),
                //new User(3, "carl.doe", "123456")
            };

            return users;
        }

        public string RegisterUser(User user)
        {
            //var resultado = 


            using (var connection = new Connection().GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SP", connection))
                {
                    List<SqlParameter> parameters = new List<SqlParameter>()
                    {

                    };

                    command.Parameters.Add(parameters.ToArray());

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter())
                    {
                        DataSet ds = new DataSet();
                        sqlAdapter.Fill(ds);

                    }
                }
            }

            return "";
        }
    }
}
