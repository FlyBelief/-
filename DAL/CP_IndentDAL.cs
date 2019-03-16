using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 订单表(CP_Indent)
    /// </summary>
    public class CP_IndentDAL
    {
        /// <summary>
        /// 显示订单表信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Indent()
        {
            string sql = "select * from CP_Indent";
            DataTable dt = DBHelper.GetTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加订单表信息
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public int PostCP_Indent(CP_Indent In)
        {
            string sql = $"insert into CP_Indent values ('{In.H_Id}','{In.II_Name}','{In.II_Time}')";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 删除订单表的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCP_Indent(string id)
        {
            string sql = "delete  from CP_Indent where II_Id="+id;
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 修改订单表的信息
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public int PutCP_Indent(CP_Indent In)
        {
            string sql = $"update CP_Indent set H_Id={In.H_Id},II_Name={In.II_Name},II_Time={In.II_Time} where II_Id={In.II_Id}";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
    }
}
