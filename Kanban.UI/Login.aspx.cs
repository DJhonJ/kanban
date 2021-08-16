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
    public partial class Login : WebUIRequest
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login";
        }

        protected string Ingresar(string username, string password)
        {
            //string username = Request.Form["txtUsuario"];
            return $"user: {username}. password: {password}, form: {FormWebUI["user_param"]}";
        }
    }
}