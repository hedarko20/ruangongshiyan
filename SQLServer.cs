using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class SQLServer
    {
        /*
         * 连接数据库的方法记录
         * 下面的字符串是从数据库对象资源管理器的数据库属性里复制出来的
         * 然后把密码改成自己的密码就能运行了
         * 下面的连接数据库，查询和修改数据库的方法
         * **/
        private static string connectionStr = @"Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";    //连接至数据库
        public SQLServer() { }
        public SQLServer(string connectionStr)
        {
            SQLServer.connectionStr = connectionStr;
        }
        public static SqlConnection GetConn()    //获取数据库连接
        {
            SqlConnection sqlconn = null;
            sqlconn = new SqlConnection(connectionStr);
            return sqlconn;
        }
        public static DataTable ExecuteQuery(string sql)    //连接数据库内的表 
        {
            using (SqlConnection conn = GetConn())
            {
                conn.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    sda.SelectCommand.Parameters.AddRange(new SqlParameter[0]);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
        public static int ExecuteNonQuery(string sql)   //执行查询
        {
            using (SqlConnection conn = GetConn())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(new SqlParameter[0]);
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
        }
    }
}
