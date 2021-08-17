using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanban.Data;
using Kanban.Domain;

namespace Kanban.Application
{
    // recibe un repository en constructor
    public class StartSession
    {
        private readonly UserRepository _userRepository;

        public StartSession(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //recibe username y password
        public string Invoke(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "usuario vacio";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "password vacia";
            }

            var users = _userRepository.GetAllUsers();

            if (users == null)
            {
                return "usuario no existe";
            }

            var user = users.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                return "usuario no existe";
            }

            return $"username: {user.UserName} - password: {user.Password}";
        }
    }
}
