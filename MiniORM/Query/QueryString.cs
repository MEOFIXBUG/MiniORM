using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Query
{
    public static class QueryString
    {
        public static string SelectAll(string table)
        {
            return $"SELECT * FROM {table}";
        }

    }
}
