using Kanban.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kanban.layout
{
    public partial class LayoutBlank : System.Web.UI.MasterPage
    {
        private readonly LayoutController _layoutController;

        public LayoutBlank()
        {
            _layoutController = new LayoutController(HttpContext.Current.Request);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string friendly = _layoutController.ControlUrlFriendly();
            if (!string.IsNullOrEmpty(friendly))
            {
                Response.Redirect(friendly);
            }
        }
    }
}