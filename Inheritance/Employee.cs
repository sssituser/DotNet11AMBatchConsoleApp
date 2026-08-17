using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public  string  ? EmployeeName { get; set; }

        public int EmployeeSalary { get; set; }

        public Employee()
        {
            Console.WriteLine("Hi Iam non static Constrctor with out paramter");
        }
        public Employee(int EmployeeId,string EmployeeName,int EmployeeSalary)
        {
            Console.WriteLine("Hi Iam Constructor with parameters");
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
        }
        public Employee(Employee emp)
        {
            Console.WriteLine("Hi Iam Copy Constructor");
            this.EmployeeId= emp.EmployeeId;
            this.EmployeeName= emp.EmployeeName;
            this.EmployeeSalary= emp.EmployeeSalary;
        }
        static Employee()
        {
            Console.WriteLine("Hi Iam Static Constructor");
        }
        public void SetEmployee(int EmployeeId,string EmployeeName, int EmployeeSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
            
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {EmployeeId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSalary}");
        }



    }
}
