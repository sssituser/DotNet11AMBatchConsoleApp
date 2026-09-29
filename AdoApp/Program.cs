using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApp
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Employee ID     : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name   : ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary : ");
            int sal = int.Parse(Console.ReadLine());
            
            BusinessLogic bl = new BusinessLogic();

            if(bl.AddEmployee(id,name, sal))
            {
                Console.WriteLine("Employee Added...");
            }
            else
            {
                Console.WriteLine("Employee Failed to Add");
            }
        }
    }
}
