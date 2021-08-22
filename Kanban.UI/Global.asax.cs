using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Kanban.Application;
using Kanban.Controller;
using Kanban.Data;
using Kanban.Data.datasource;
using Kanban.Infrastructure.database;
using Kanban.Interface;
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

        protected void Session_Start(object sender, EventArgs e)
        {
            IUnityContainer container = this.AddUnity();
            ModuleUI(container);
        }

        private void ConfigDependencyInjection()
        {
            IUnityContainer container = this.AddUnity();

            ModuleInfrastructure(container);
            ModuleApplication(container);
            //ModuleUI(container);
        }

        private void ModuleInfrastructure(IUnityContainer container)
        {
            container.RegisterType<TransactSQL, TransactSQL>();
            container.RegisterType<ILocalDataUser, UserData>();
        }

        private void ModuleApplication(IUnityContainer container)
        {
            container.RegisterType<UserRepository, UserRepository>();
            container.RegisterType<StartSession, StartSession>();
        }

        private void ModuleUI(IUnityContainer container)
        {
            container.RegisterInstance(typeof(HttpSessionState), Session);
            container.RegisterInstance(typeof(Default), new Default());
            container.RegisterType<DefaultController, DefaultController>();
            container.RegisterType<IDefaultView, Default>();
            container.RegisterType<LoginController, LoginController>();
            container.RegisterType<RegisterController, RegisterController>();
        }
    }
}