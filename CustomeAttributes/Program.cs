






using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type type = typeof(Employee);

        Console.WriteLine("Member Variables:");
        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine("- " + prop.Name);
        }

        Console.WriteLine("\nAttributes on 'Id':");
        var idProperty = type.GetProperty("emp_id");
        var attributes = idProperty.GetCustomAttributes(typeof(MyCustomAttribute), false);

        foreach (MyCustomAttribute attr in attributes)
        {
            Console.WriteLine($"IsPrimaryKey: {attr.IsPrimaryKey}");
            Console.WriteLine($"IsIndexed: {attr.IsIndexed}");
            Console.WriteLine($"IsAutoIncrement: {attr.IsAutoIncrement}");
        }
    }
}
