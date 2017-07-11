using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BELayer;

namespace DALayer
{
    public class DAL
    {
        public SqlConnection con = new SqlConnection(@"Data Source=STEE-LIS-PC\SQLEXPRESS;Initial Catalog=laufer;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand("");

        public int userinsert(BEL beobj)
        {
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spinsert";
            cmd.Parameters.AddWithValue("@name", beobj.name);
            cmd.Parameters.AddWithValue("@age", beobj.age);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
            

        }
    }
}
