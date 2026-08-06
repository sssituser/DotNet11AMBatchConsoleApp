using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConsoleApp
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmployeeId = 111;
            emp1.EmployeeName = "kiran";
            emp1.EmployeeSalary = 50000; // Write Propery

            Console.WriteLine("Reading the data from Properties");
            Console.WriteLine($"Employee ID     : {emp1.EmployeeId}");
            Console.WriteLine($"Employee Name   : {emp1.EmployeeName}");
            Console.WriteLine($"Employee Salary : {emp1.EmployeeSalary}");

        }
    }
}



