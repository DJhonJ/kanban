using Kanban.Data.datasource;
using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Infrastructure
{
    public class UserData: ILocalDataUser
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>()
            {
                new User(1, "jhon.doe", "123456"),
                new User(2, "emma.doe", "123456"),
                new User(3, "carl.doe", "123456")
            };

            return users;
        }
    }
}
