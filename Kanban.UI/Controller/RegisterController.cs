using Kanban.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Controller
{
    public class RegisterController
    {
        private readonly RegisterUser _registerUser;

        public RegisterController(RegisterUser registerUser)
        {
            _registerUser = registerUser;
        }

        public string RegisterUser(string nombre, string email, string username, string password)
        {
            return _registerUser.Invoke(nombre, email, username, password);
        }
    }
}