using Kanban.Data.datasource;
using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Data
{
    public class UserRepository
    {
        private ILocalDataUser _localDataUser;

        public UserRepository(ILocalDataUser localDataUser)
        {
            _localDataUser = localDataUser;
        }

        public List<User> GetAllUsers() => _localDataUser.GetAllUsers();
        public User GetUserByCredentials(User user) => _localDataUser.GetUserByCredentials(user);
        public string RegisterUser(User user) => _localDataUser.RegisterUser(user);
    }
}
