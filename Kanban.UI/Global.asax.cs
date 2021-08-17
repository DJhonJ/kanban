using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Kanban.Application;
using Kanban.Code.Login;
using Kanban.Data;
using Kanban.Data.datasource;
using Kanban.Infrastructure;
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

            //container.RegisterType<ILocalDataUser, UserData>();
            container.RegisterType<ILocalDataUser, UserData>();
            container.RegisterType<UserRepository, UserRepository>();
            container.RegisterType<StartSession, StartSession>();
            container.RegisterType<LoginController, LoginController>();
        }
    }
}