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
    /// 评论表(CP_Comment)
    /// </summary>
    public class CP_CommentDAL
    {
        /// <summary>
        /// 显示评论信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCp_Comment()
        {
            string sql = "select * from Cp_Comment";
            DataTable dt = DBhelper.GetTable(sql);
            return dt;
        }
        /// <summary>
        /// 添加评论信息
        /// </summary>
        /// <returns></returns>
        public int PostCp_Comment(CP_Comment m)
        {
            string sql = $"insert into Cp_Comment values('{m.C_Name}','{m.C_Describe}','{m.H_Id}','{m.HH_Id}')";
            int n = DBhelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 删除评论信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCp_Comment(string id)
        {
            string sql = "delete from Cp_Comment where C_Id = " + id;
            int n = DBhelper.ExecuteNonQuery(sql);
            return n;
        }
        /// <summary>
        /// 修改评论信息
        /// </summary>
        /// <returns></returns>
        public int PutCp_Comment(CP_Comment m)
        {
            string sql = $"update CP_Comment set C_Name={m.C_Name},C_Describe={m.C_Describe},H_Id={m.H_Id},HH_Id={m.HH_Id} where C_id=" + m.C_Id;
            int n = DBhelper.ExecuteNonQuery(sql);
            return n;
        }

    }
}
