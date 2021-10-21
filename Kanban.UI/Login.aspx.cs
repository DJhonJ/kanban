using Kanban.Controller;
using Kanban.Domain;
using Kanban.Interface;
using Kanban.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kanban
{
    public partial class Login : WebUIRequest, IResponseView
    {
        private readonly LoginController _loginController;

        public Login()
        {
            _loginController = new LoginController(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login";

            var s = Response;
        }

        protected void Ingresar(string username, string password)
        {
            _loginController.StartSession(username, password);
            //Redirect("Default.aspx");
            RedirectClient = "Default.aspx";
        }

        public void ResponseView(object result)
        {
            ResponseClient(result);
        }

        public void Redirect(string url)
        {
            HttpContext.Current.Response.Redirect(url);
        }
    }
}