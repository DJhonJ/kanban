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
        private readonly TransactSQL _transact;

        public UserData(TransactSQL t)
        {
            _transact = t;
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

        public string RegisterUser(User user)
        {
            var resultado = _transact.ExecuteQuery("GestionUsuario", new ParameterSQL("oper", "S", SqlDbType.Char, 1, ParameterDirection.Input)).GetTable(0);

            return "";
        }
    }
}
