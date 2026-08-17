using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Class3
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmployee(111, "aaaa",5000);
            emp.GetEmployee();


            emp.Equals(new object());
            emp.ToString();
            emp.GetType();
            emp.GetHashCode();

        }
    }
}
