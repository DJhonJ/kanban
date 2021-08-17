using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanban.Domain;

namespace Kanban.Application
{
    // resive un repository en constructor
    public class StartSession
    {
        //recibe username y password
        public string Invoke(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "usuario vacio";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "password vacia";
            }

            var user = new User(0, username, password);

            return $"username: {user.UserName}. password: {user.Password}";
        }
    }
}
