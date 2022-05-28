using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesAndReflections
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; }
        public Type _Type { get; set; }

        public bool IsRequired { get; set; }
        public ColumnAttribute(string columnName,Type type, bool isRequired)
        {
            ColumnName = columnName;
            _Type = type;
            IsRequired = isRequired;

        }
    }
}
