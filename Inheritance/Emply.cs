using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Emply : Deparatment
    {
        public int EmpId { get;private set; }

        public string EmpName { get; private set; }

        public int EmpSal { get; private set; }

        public Emply(int EmpId, string EmpName, int EmpSal,int DeptId,string DeptName) :base(DeptId,DeptName)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"Employee ID : {EmpId}\tEmployee Name : {EmpName}\tEmployee Salary : {EmpSal}\tDepartmentId : {DeptId}\tDeptName : {DeptName}";
        }

    }
}
