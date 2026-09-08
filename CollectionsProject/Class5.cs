using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee(111, "abc", 5000));
            stack.Push(new Employee(113, "def", 4000));
            stack.Push(new Employee(112, "pqr", 7000));
            stack.Push(new Employee(114, "lmn", 6000));
            Console.WriteLine("Elements in the stack are");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
