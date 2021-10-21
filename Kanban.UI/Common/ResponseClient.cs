using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Common
{
    public class ResponseClient
    {
        public int Code { get; set; }
        public string StringCode { get; set; }
        public string StackTrace { get; set; }
        public string Message { get; set; }
        public object ResultMethod { get; set; }
        public object Redirect { get; set; }
    }
}