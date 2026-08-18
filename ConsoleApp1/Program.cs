using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(111, "abc", 40000);
            Employee emp2 = new Employee(112, "def", 50000);
            Employee emp3 = new Employee(113, "pqr", 60000);
            Employee emp4 = new Employee(114, "lmn", 70000);
            Employee emp5 = new Employee(115,"kkk",5000);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine(emp4);
            Console.WriteLine(emp5);
            Console.WriteLine(emp1.EmId);
        }
    }
}
