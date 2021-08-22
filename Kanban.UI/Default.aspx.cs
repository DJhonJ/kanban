using Kanban.Controller;
using Kanban.Interface;
using Kanban.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kanban
{
    public partial class Default : WebUIRequest, IDefaultView
    {
        private readonly DefaultController defaultController;

        public Default() { }

        public Default(DefaultController defaultController)
        {
            this.defaultController = defaultController;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            defaultController.ValidarSessionState();
        }

        public void SessionOff(string redirectUrl)
        {
            HttpContext.Current.Response.Redirect(redirectUrl);
        }
    }
}