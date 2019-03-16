using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DAL
{
    public  class DBHelper
    {
        public static string connStr = "Data Source = 10.1.152.17,1433; Initial Catalog = CentralPlains; User ID = sa";  
        //创建公用的SqlConnecttion
        public static SqlConnection sqlconn = new SqlConnection(connStr);
        //创建公用的SqlCommand
        static SqlCommand sqlcmd = new SqlCommand();
        //执行数据库操作
        public static int ExecuteNonQuery(string sql)
        {
            sqlcmd.Connection = sqlconn;//指定链接对象
            sqlcmd.CommandText = sql;//指定sql语句
            int result = 0;
            try
            {
                sqlconn.Open();//打开数据库
                result = sqlcmd.ExecuteNonQuery();//执行增删改语句
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlconn.Close();//关闭数据库
            }
            return result;
        }
        //接收一条Sql返回一个SqlDataReader对象
        public static SqlDataReader ExecuteReader(string sql)
        {
            sqlcmd.Connection = sqlconn;//链接对象
            sqlcmd.CommandText = sql;//执行Sql
            SqlDataReader reader = null;
            try
            {
                sqlconn.Open();//打开数据库
                reader = sqlcmd.ExecuteReader();//拿到需要的读取器SqlDataReader对象
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // sqlconn.Close();
            }
            return reader;//将结果返回给 DAL
        }
        //返回结果只有一个单元格 登陆 查询总数 
        public static object ExecuteScalar(string sql)
        {
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = sql;
            object result = null;
            try
            {
                sqlconn.Open();
                result = sqlcmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlconn.Close();
            }
            return result;
        }


        public static DataTable GetTable(string sql) {
            DataTable dt = new DataTable();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = sql;
            SqlDataAdapter sqlada=new SqlDataAdapter(sqlcmd);
            try
            {
                sqlada.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

    }
    public class DBHelper<T> where T : new() {
        public static List<T> GetList(string sql)
        {
            DataTable dt = DBHelper.GetTable(sql);
            List<T> list = new List<T>();// 定义集合

            Type type = typeof(T); // 获得此模型的类型

            string tempName = "";

            foreach (DataRow dr in dt.Rows)

            {

                T t = new T();

                PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性

                foreach (PropertyInfo pro in propertys)
                {
                    tempName = pro.Name;

                    if (dt.Columns.Contains(tempName))

                    {

                        if (!pro.CanWrite) continue;

                        object value = dr[tempName];

                        if (value != DBNull.Value)

                            pro.SetValue(t, value, null);

                    }

                }
                list.Add(t);

            }
            return list;
        }
    }
}
