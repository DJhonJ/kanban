using Kanban.Application;
using Kanban.Application.Interface;
using Kanban.Domain;
using Kanban.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Attributes;

namespace Kanban.Controller
{
    public class LoginController: IController
    {
        private StartSession _startSession;
        private IResponseView _responseView;

        public LoginController(IResponseView responseView)
        {
            _startSession = new StartSession(this);
            _responseView = responseView;
        }

        public void StartSession(string username, string password)
        {
            _startSession.Invoke(username, password);
        }

        public void Fail(string message)
        {
            //podria usar el _responseView, para enviarle el mensaje a la vista y que la vista responda
            //con el metodo ResponseClient
            //_responseView.ResponseView(message);
            throw new Exception(message);
        }

        //public void Success(User user) => _responseView.ResponseView(user);
    }
}