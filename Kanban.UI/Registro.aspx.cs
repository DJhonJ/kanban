using Kanban.Code;
using Kanban.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kanban
{
    public partial class Registro : WebUIRequest
    {
        private readonly RegisterController _register;

        public Registro(RegisterController register)
        {
            _register = register;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register()
        {
            _register.RegisterUser();
        }
    }
}