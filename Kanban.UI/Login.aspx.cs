using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kanban
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login";

            var w = Request.Form[""];
        }

        protected void Ingresar(object sender, EventArgs e)
        {
            string username = Request.Form["txtUsuario"];
        }

        [WebMethod]
        protected static string Ingresar()
        {
            //string username = Request.Form["txtUsuario"];
            return "hola desde c#";
        }
    }
}