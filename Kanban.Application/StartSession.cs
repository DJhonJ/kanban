using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanban.Application.Interface;
using Kanban.Data;
using Kanban.Domain;
using Kanban.Infrastructure.database;

namespace Kanban.Application
{
    // recibe un repository en constructor
    public class StartSession
    {
        private UserRepository _userRepository;
        private readonly IController _controller;

        public StartSession(IController controller)
        {
            _controller = controller;
            _userRepository = new UserRepository(new UserData(new TransactSQL()));
        }

        //recibe username y password
        public User Invoke(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                _controller.Fail("usuario vacio");
                return null;
            }

            if (string.IsNullOrEmpty(password))
            {
                _controller.Fail("password vacia");
                return null;
            }

            User user = _userRepository.GetUserByCredentials(new User(0, username, password, string.Empty, string.Empty));

            if (user == null)
            {
                _controller.Fail("usuario no existe");
                return null;
            }

            return user;
            //_controller.Success(user);
        }
    }
}
