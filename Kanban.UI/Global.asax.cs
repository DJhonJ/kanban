using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Kanban.Application;
using Kanban.Code.Login;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;

namespace Kanban
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ConfigDependencyInjection();
        }

        private void ConfigDependencyInjection()
        {
            var container = this.AddUnity();
            container.RegisterType<LoginController, LoginController>();
            container.RegisterType<StartSession, StartSession>();
        }
    }
}