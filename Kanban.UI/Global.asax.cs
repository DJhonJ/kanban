using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Kanban.Application;
using Kanban.Application.Interface;
using Kanban.Common;
using Kanban.Controller;
using Kanban.Data;
using Kanban.Data.datasource;
using Kanban.Infrastructure.database;
using Kanban.Interface;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using Unity.Injection;

namespace Kanban
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("principal-key", "kanban", "~/Default.aspx");
            RouteTable.Routes.MapPageRoute("login-key", "login", "~/Login.aspx");
            ConfigDependencyInjection();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //IUnityContainer container = this.AddUnity();
            //ModuleUI(container);

            //ConfigDependencyInjection();
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        private void ConfigDependencyInjection()
        {
            IUnityContainer container = this.AddUnity();
            //IUnityContainer container = new UnityContainer();

            ModuleInfrastructure(container);
            ModuleApplication(container);
            ModuleUI(container);
        }

        private void ModuleInfrastructure(IUnityContainer container)
        {
            container.RegisterType<TransactSQL>();
            container.RegisterType<ILocalDataUser, UserData>();
        }

        private void ModuleApplication(IUnityContainer container)
        {
            //container.RegisterType<UserRepository>();
            //container.RegisterType<StartSession>();
            //container.RegisterType<IController, LoginController>(new InjectionMethod("GoUserRepository", new StartSession()));
            //container.Resolve<LoginController>();
        }

        private void ModuleUI(IUnityContainer container)
        {
            container.RegisterType<ResponseClient>();
            //container.RegisterType<HttpSessionState>();
            //container.RegisterInstance(typeof(HttpSessionState), Session);

            //login
            //container.RegisterInstance(typeof(Login), new Login());
            //container.RegisterType<LoginController>();
            //container.RegisterInstance<IResponseView>(new Login());
            //container.RegisterSingleton<IResponseView, Login>();

            //container.RegisterInstance(typeof(StartSession), new StartSession());
            //container.RegisterInstance(typeof(IResponseView), new Login());
            //container.RegisterInstance(typeof(IController), new LoginController());
            //container.RegisterInstance(typeof(StartSession), new StartSession());

            //container.RegisterSingleton<StartSession>();
            //container.RegisterInstance(new LoginController());
            //container.RegisterSingleton<IController, LoginController>();
            //container.RegisterSingleton<IResponseView, Login>();

            //container.RegisterType<StartSession>();

            //container.ResolveAll<IResponseView>();
            //container.ResolveAll<IController>();
            //default//
            //container.RegisterType<IDefaultView, Default>();
            //container.RegisterSingleton<IDefaultView, Default>();

            //container.RegisterType<DefaultController>();
            //container.RegisterType<IController, LoginController>();
            //container.RegisterInstance<IDefaultView>(new Default());

            //register
            //container.RegisterType<RegisterController>();
        }
    }
}