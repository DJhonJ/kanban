using Kanban.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Code
{
    public class RegisterController
    {
        private readonly RegisterUser _registerUser;

        public RegisterController(RegisterUser registerUser)
        {
            _registerUser = registerUser;
        }

        public void RegisterUser()
        {
            _registerUser.Invoke("", "", "", "");
        }
    }
}