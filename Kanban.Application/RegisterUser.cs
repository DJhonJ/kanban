using Kanban.Data;
using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Application
{
    public class RegisterUser
    {
        private readonly UserRepository _userRepository;

        public RegisterUser(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Invoke(string nombre, string email, string username, string password)
        {
            return _userRepository.RegisterUser(new User(0, username, password, nombre, email));
        }
    }
}
