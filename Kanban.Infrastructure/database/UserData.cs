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
        private readonly TransactSQL transactSQL;

        public UserData(TransactSQL t)
        {
            transactSQL = t;
        }

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

        public User GetUserByCredentials(User user)
        {
            Dictionary<string, object> usuario = transactSQL.ExecuteQuery("GestionUsuario", new ParameterSQL("oper", "V", SqlDbType.Char, 1)
                                                                                          , new ParameterSQL("usuario", user.UserName, SqlDbType.VarChar, 50)
                                                                                          , new ParameterSQL("clave", user.Password, SqlDbType.VarChar, 50)).ToDictionary(0);

            if (usuario.Count > 0 && usuario.ContainsKey("Id"))
            {
                return new User(int.Parse(usuario["Id"].ToString()), usuario["Usuario"].ToString(),
                    usuario["Clave"].ToString(), usuario["Nombre"].ToString(), usuario["Email"].ToString());
            }

            return null;
        }

        public string RegisterUser(User user)
        {
            var resultado = transactSQL.ExecuteQuery("GestionUsuario", new ParameterSQL("oper", "I", SqlDbType.Char, 1, ParameterDirection.Input)
                                                                     , new ParameterSQL("nombre", user.Name, SqlDbType.VarChar, 100)
                                                                     , new ParameterSQL("email", user.Email, SqlDbType.VarChar, 100)
                                                                     , new ParameterSQL("usuario", user.UserName, SqlDbType.VarChar, 50)
                                                                     , new ParameterSQL("clave", user.Password, SqlDbType.VarChar, 50)).ToDictionary(0);
            return resultado["Id"].ToString();
        }
    }
}
