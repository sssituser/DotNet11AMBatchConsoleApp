using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Employee
    {
        private int employeeId;
        private string employeeName;
        public void SetEmployee(int employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {this.employeeId}\tEmployee Name : {this.employeeName}");
        }
        
    }
}
