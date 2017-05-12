using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Attributes
{
    class ColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}
