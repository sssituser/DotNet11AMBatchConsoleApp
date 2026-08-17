using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Inheritance
{
    internal class Class4
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee(111,"abc",60000);
            Employee emp5 = new Employee(112,"def",70000);
            Employee emp6 = new Employee(113,"pqr",80000);
            Employee emp7 = new Employee(emp4);
            Employee emp8 = new Employee(emp5);
            Employee emp9 = new Employee(emp6);
            emp1.GetEmployee();
            emp2.GetEmployee();
            emp3.GetEmployee();
            emp4.GetEmployee();
            emp5.GetEmployee();
            emp6.GetEmployee();
            emp7.GetEmployee();
            emp8.GetEmployee();
            emp9.GetEmployee();

            
        }
    }
}
