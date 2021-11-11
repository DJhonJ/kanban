using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Controller
{
    public class LayoutController
    {
        private readonly HttpRequest _request;

        public LayoutController(HttpRequest request)
        {
            _request = request;
        }

        /// <summary>
        /// Retorna las urls friendly.
        /// </summary>
        /// <returns></returns>
        public string ControlUrlFriendly()
        {
            string url = string.Empty;

            if (_request != null && _request.Url.AbsolutePath.Contains(".aspx"))
            {
                switch(_request.Url.AbsolutePath.ToLower())
                {
                    case "/default.aspx":
                        url = "kanban";
                        break;

                    case "/login.aspx":
                        url = "login";
                        break;
                }
            }

            return url;
        }
    }
}