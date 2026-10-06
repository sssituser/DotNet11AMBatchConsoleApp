
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppEntityFramework
{
    internal class BuinessLogic
    {
        SnehaEFDb Db = new SnehaEFDb();

        public bool AddEmployee (Tbl_Employee employee)
        {
            Db.Tbl_Employee.Add(employee);
            return Db.SaveChanges() > 0;
        }
        public Tbl_Employee GetEmployeeById (Tbl_Employee employee)
        {
           
                if (IsEmployee(employee))
                {
                    return Db.Tbl_Employee.Where(emp => emp.eid == employee.eid).FirstOrDefault();
                }
                else
                {
                    return null;
                }
           
        }
        public bool CheckEmployees ()
        {
            return Db.Tbl_Employee.Count() > 0;
        }
        public bool IsEmployee (Tbl_Employee employee)
        {
            return Db.Tbl_Employee.Where(emp => emp.eid == employee.eid).Count() > 0;
        }
        public List<Tbl_Employee> GetEmployees ()
        {
            if (CheckEmployees())
            {
                return Db.Tbl_Employee.ToList();
            }
            return null;
        }
        public bool UpdateEmployee (Tbl_Employee employee)
        {


            Tbl_Employee eemp = GetEmployeeById(employee);
            eemp.ename = employee.ename;
            eemp.esal = employee.esal;
            return Db.SaveChanges() > 0;

        }

        public bool DeleteEmployeeById (Tbl_Employee employee)
        {



            employee = GetEmployeeById(employee);
            Db.Tbl_Employee.Remove(employee);
            return Db.SaveChanges() > 0;


        }


    }
}
