using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace 数据库连接
{
   
    public class Sqlutil
    {
        SqlConnection con;
        public Sqlutil() {
            con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=MyFinancing;User ID=sa;password=123456";
           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }

 }
        public int nonSelect(string sql)
        {
            SqlCommand com = new SqlCommand(sql, con);
            return com.ExecuteNonQuery();
        }

        //逐行读取查询
        public SqlDataReader selectOne(string sql)
        {
            SqlCommand com = new SqlCommand(sql, con);
            return com.ExecuteReader();
        }
        //全表读取查询
        public DataTable selectAll(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "FlowSelect");
            return ds.Tables["FlowSelect"];

        }


        //关闭
        public void closeCon()
        {
            this.con.Close();
        }
    }
}
