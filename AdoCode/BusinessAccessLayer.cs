using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System;

namespace AdoCode
{
    internal class BusinessAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public BusinessAccessLayer ()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sneha;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool AddEmployee (int eid, string ename, int esal)
        {
            con.Close();
            cmd.CommandText = $"insert into employee values({eid},'{ename}',{esal})";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }

        public bool UpdateEmployee (int eid, string ename, int esal)
        {
            con.Close();
            cmd.CommandText = $"update employee set ename='{ename}',esal = {esal} where eid = {eid} ";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }

        public bool DeleteEmployeeById (int eid)
        {
            con.Close();
            cmd.CommandText = $"delete from  employee where eid = {eid})";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }

        public SqlDataReader GetEmployees ()
        {
            con.Close();
            cmd.CommandText = "select * from employee";
            con.Open();
            dr = cmd.ExecuteReader();
            return dr;

        }
        public bool CheckEmployee (int id)
        {
            con.Close();
            cmd.CommandText = $"select count(*) from employee where eid = {id}";
            con.Open();
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return (res > 0);
        }

    }
}
