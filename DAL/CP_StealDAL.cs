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
    /// 盗窃表(CP_Steal) 
    /// </summary>
    public class CP_StealDAL
    {
        /// <summary>
        /// 显示盗窃表(CP_Steal) 
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Steal()
        {
            string sql = "select * from CP_Steal";
            DataTable dt = DBHelper.GetTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加盗窃信息
        /// </summary>
        /// <returns></returns>
        public int PostCP_Steal(CP_Steal St)
        {
            string sql = $"insert into CP_Steal values ('{St.SS_Name}','{St.SS_Phone}','{St.SS_Time}')";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n; ;
        }
        /// <summary>
        /// 删除盗窃信息
        /// </summary>
        /// <returns></returns>
        public int DeleteCP_Steal(string id)
        {
            string sql = "delete from CP_Steal where  SS_Id="+id;
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 修改盗窃信息
        /// </summary>
        /// <param name="St"></param>
        /// <returns></returns>
        public int PutCP_Steal(CP_Steal St)
        {
            string sql = $"update CP_Steal set SS_Name={St.SS_Name},SS_Phone={St.SS_Phone},SS_Time={St.SS_Time} where  SS_Id={St.SS_Id}";
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
     }
}
