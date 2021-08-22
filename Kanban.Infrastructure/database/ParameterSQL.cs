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
        public ParameterSQL(string name, object value, SqlDbType dbType, int size = 0, ParameterDirection direction = ParameterDirection.Input)
        {
            if (value != null && string.IsNullOrEmpty(value.ToString()))
            {
                switch (dbType)
                {
                    case SqlDbType.Int:
                    case SqlDbType.Decimal:
                    case SqlDbType.BigInt:
                    case SqlDbType.SmallInt:
                    case SqlDbType.TinyInt:
                    case SqlDbType.Money:
                        value = 0;
                        break;
                }
            }

            Name = name;
            Value = value ?? DBNull.Value;
            SqlDbType = dbType;
            Size = size;
            Direction = direction;
        }

        public string Name { get; set; }
        public object Value { get; set; }
        public SqlDbType SqlDbType { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; }
    }
}
