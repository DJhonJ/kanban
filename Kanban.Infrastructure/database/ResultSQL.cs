using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.Infrastructure.database
{
    public class ResultSQL
    {
        private readonly DataSet _dataset;

        public ResultSQL(DataSet set)
        {
            _dataset = set;
        }

        public DataTable GetTable(int index = 0)
        {
            if (_dataset.Tables.Count > 0)
            {
                return _dataset.Tables[index];
            }

            return new DataTable();
        }
    }
}
