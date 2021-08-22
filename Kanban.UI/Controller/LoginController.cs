using Kanban.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Controller
{
    public class LoginController
    {
        private readonly StartSession _startSession;

        public LoginController(StartSession startSessionUserCase)
        {
            _startSession = startSessionUserCase;
        }

        public string StartSession(string username, string password)
        {
            return _startSession.Invoke(username, password);
        }
    }
}