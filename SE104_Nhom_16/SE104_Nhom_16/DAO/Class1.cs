using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SE104_Nhom_16
{
    public class Class1
    {
        SqlConnection con = new SqlConnection(@"Data Source=GIA-THE;Initial Catalog=quanlynhasach;Integrated Security=True");
        public void myconnect()
        {   con.Open();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void myclose()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            ds.Fill(dt);
            return (dt);
        }



    }
}
