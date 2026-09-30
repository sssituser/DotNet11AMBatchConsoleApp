using System.Data.SqlClient;
using System.Data;
namespace AdoCode
{
    
    internal class BusinessLogicLayer
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataRow row;
        public BusinessLogicLayer ()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sneha;Integrated Security=True;Encrypt=False");
            da = new SqlDataAdapter("select * from employee",con);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds,"employee");
            ds.Tables["employee"].Constraints.Add("empid_pk", ds.Tables["employee"].Columns["eid"],true);
            da.Update(ds.Tables["employee"]);
        }
        public bool RegisterEmployee(int id,string name,int sal)
        {
            row = ds.Tables["employee"].NewRow();
            row["eid"] = id;
            row["ename"] = name;
            row["esal"] = sal;
            ds.Tables["employee"].Rows.Add(row);
            int res = da.Update(ds, "employee");
            return res > 0;
        }
        public DataSet GetEmployees ()
        {

            return ds;
        }
        public DataRow GetEmployeeById (int id)
        {
            row = ds.Tables["employee"].Rows.Find(id);
            if(row== null)
                return null;
            return row;
        }
        public bool DeleteEmployeeById(int id)
        {
            ds.Tables["employee"].Rows.Find(id).Delete();
            int res = da.Update(ds, "employee");
            return res > 0;
        }
        public bool UpdateEmployee(int id,string name,int sal)
        {
            row = ds.Tables["employee"].Rows.Find(id);
            row["ename"] = name;
            row["esal"] = sal;
            int res = da.Update(ds, "employee");
            return res > 0;
        }
        
        public bool CheckEmployee (int id)
        {
            row = ds.Tables["employee"].Rows.Find(id);
            if(row == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
