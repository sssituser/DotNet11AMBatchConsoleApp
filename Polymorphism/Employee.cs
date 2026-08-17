using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Employee
    {
        private int empId;
        private string empName;
        private int empSal;
        public void SetEmployee(int empId, string empName, int empSal)
        {
            this.empId= empId;
            this.empName= empName;
            this.empSal= empSal;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employe ID :{empId}\tEmployeeName : {empName}\tEmployeeSalary:{empSal}");
        }
        public override string ToString()
        {
            return $"Employe ID :{empId}\tEmployeeName : {empName}\tEmployeeSalary:{empSal}";
        }
    }
}
