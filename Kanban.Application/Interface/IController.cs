using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Application.Interface
{
    public interface IController
    {
        //void Success(User user);
        void Fail(string message);
    }
}
