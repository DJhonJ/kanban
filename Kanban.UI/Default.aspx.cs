using Kanban.Common;
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
    public partial class Default : WebUIRequest//, IDefaultView
    {
        private readonly DefaultController _defaultController;

        //public Default(ResponseClient response)
        //{
        //}

        //public Default(DefaultController defaultController)
        //{
        //    _defaultController = defaultController;
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (_defaultController == null)
            //{
            //    SessionOff("Login.aspx");
            //}

            //_defaultController.ValidarSessionState();
        }

        public void SessionOff(string redirectUrl)
        {
            HttpContext.Current.Response.Redirect(redirectUrl);
        }
    }
}