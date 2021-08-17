using Kanban.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Data.datasource
{
    public interface ILocalDataUser
    {
        List<User> GetAllUsers();
    }
}
