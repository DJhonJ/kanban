using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Interface
{
    public interface IResponseView
    {
        void ResponseView(object result);
        void Redirect(string url);
    }
}
