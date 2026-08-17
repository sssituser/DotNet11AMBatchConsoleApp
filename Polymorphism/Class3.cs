using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmployee(111, "Sneha", 60000);
            emp.GetEmployee();
            Console.WriteLine(emp);
        }
    }
}
