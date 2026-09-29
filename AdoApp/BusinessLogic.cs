using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdoApp
{
    internal class BusinessLogic
    {
        SqlConnection con;
        SqlCommand cmd;
        public BusinessLogic ()
        {
            //Basic Configuration of Connected Oriented Object
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=adonetdb;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool AddEmployee (int eid, string ename, int esal)
        {
            cmd.CommandText = $"insert into employee values({eid},'{ename}',{esal})";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res == 1;
        }

    }
}
