using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kanban.Infrastructure.database
{
    public class ParameterSQL
    {
        public ParameterSQL(string name, string value, SqlDbType dbType, int size, ParameterDirection direction)
        {
            Name = name; Value = value; SqlDbType = dbType;
            Size = size; Direction = direction;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public SqlDbType SqlDbType { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; }
    }
}
