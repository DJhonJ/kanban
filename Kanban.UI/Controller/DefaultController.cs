using Kanban.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Kanban.Controller
{
    public class DefaultController
    {
        private readonly HttpSessionState Session;
        private readonly IDefaultView _defaultView;

        public DefaultController(HttpSessionState Session, IDefaultView defaultView)
        {
            this.Session = Session;
            _defaultView = defaultView;
        }

        public void ValidarSessionState()
        {
            if (Session["login"] == null || (Session["login"] != null && Session["login"].ToString() == "0"))
            {
                _defaultView.SessionOff("Login.aspx");
            }
        }
    }
}