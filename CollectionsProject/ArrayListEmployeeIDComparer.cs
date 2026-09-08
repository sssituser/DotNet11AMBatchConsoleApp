using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class ArrayListEmployeeIDComparer : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
            if (x.EmployeId < y.EmployeId)
            {
                return -1;
            }
            if (x.EmployeId > y.EmployeId)
            {
                return 1;
            }
            return 0;
            //return x.EmployeName.CompareTo(y.EmployeName);
        }
    }
}
