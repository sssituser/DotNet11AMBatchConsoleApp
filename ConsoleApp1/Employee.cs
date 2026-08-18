using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public  int EmId { get; private set; }
        public string EmpName { get; private set; }
        public int EmpSal { get; private set; }
        public Employee()
        {

        }
        public Employee(int EmId, string EmpName, int EmpSal)
        {
            this.EmId = EmId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public override string ToString()
        {
            return $"Employee ID : {EmId}\tEmployee Name : {EmpName}\tEmployee Salary : {EmpSal}";
        }
        ~Employee()
        {
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Object Destroyed");
        }
    }
}
