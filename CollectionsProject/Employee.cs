using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class Employee 
    {
        public int EmployeId { get; set; }
        public string EmployeName { get; set; }
        public int EmployeeSalary { get; set; }

        public Employee(int EmployeId, string EmployeName, int EmployeeSalary)
        {
            this.EmployeId = EmployeId;
            this.EmployeName = EmployeName;
            this.EmployeeSalary = EmployeeSalary;
        }

        public override string ToString()
        {
            return $"{EmployeId}\t{EmployeName}\t{EmployeeSalary}";
        }

       
    }
}
