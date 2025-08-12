using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.All)]
     public class MyCustomAttribute : Attribute
{
    public bool IsIndexed;
    public bool IsPrimaryKey;
    public bool IsAutoIncrement;

    public MyCustomAttribute(bool isIndexed, bool isPrimaryKey, bool isAutoIncrement)
    {
        IsIndexed = isIndexed;
        IsPrimaryKey = isPrimaryKey;
        IsAutoIncrement = isAutoIncrement;
    }

}

