using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Deparatment
    {
        public int DeptId { get; private set; }
        public  string  DeptName { get; private set; }

        public Deparatment(int DeptId, string DeptName)
        {
            this.DeptId = DeptId;
            this.DeptName = DeptName;
        }
        public override string ToString()
        {
            return $"Depratment ID : {DeptId}\tDepartment Name : {DeptName}";
        }
    }
}
