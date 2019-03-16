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
    /// 8. Vip表(CP_Vip)
    /// </summary>
    public class CP_VipDAL
    {
        /// <summary>
        /// 显示Vip表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Vip()
        {
            string sql = "select * from CP_Vip";
            DataTable dt = DBHelper.GetTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加Vip信息
        /// </summary>
        /// <param name="Vip"></param>
        /// <returns></returns>
        public int PostCP_Vip(CP_Vip  Vip)
        {
            string sql = $"insert into CP_Vip values ('{Vip.V_Path}','{Vip.V_Name}')";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 删除VIP信息 
        /// </summary>
        /// <returns></returns>
        public int DeleteCP_Vip(string id)
        {
            string sql = "delete from CP_Vip where V_Id="+id;
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 修改VIP信息 
        /// </summary>
        /// <param name="Vip"></param>
        /// <returns></returns>
        public int PutCP_Vip(CP_Vip Vip)
        {
            string sql = $"update CP_Vip set V_Name={Vip.V_Name},V_Path={Vip.V_Path} where V_Id={Vip.V_Id}";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
    }
}
