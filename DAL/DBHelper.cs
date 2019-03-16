using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class DBHelper
    {
        
     
        public static string connStr = "Data Source=10.1.152.17,1433;Initial Catalog=CentralPlains;User ID=sa ,pwd=123456";
        public static SqlConnection cnn = new SqlConnection(connStr);
      
        /// <summary>
        /// 执行增删改的操作
        /// </summary>
        /// <param name="sql">sql命令</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            int result = command.ExecuteNonQuery();
            cnn.Close();
            return result;
        }
        /// <summary>
        /// 查询单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            object result = command.ExecuteScalar();
            cnn.Close();
            return result;
        }
        /// <summary>
        /// 返回数据表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        /// <summary>
        /// 返回DataReader对象，使用结束后，勿忘关闭DataReader与数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            return command.ExecuteReader();
        }
        /// <summary>
        /// 打开数据库
        /// </summary>
        public static void Open() 
        {
            if (cnn.State==ConnectionState.Broken||cnn.State==ConnectionState.Open)
            {
                cnn.Close();
            }
            cnn.Open();
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        public static void Close()
        {
            cnn.Close();
        }
    }
}