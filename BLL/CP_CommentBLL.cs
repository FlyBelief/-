using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DAL;

namespace BLL
{
    public class CP_CommentBLL
    {
        CP_CommentDAL dal = new CP_CommentDAL();
        /// <summary>
        /// 显示评论信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCp_Comment()
        {
            return dal.GetCp_Comment();
        }
        /// <summary>
        /// 添加评论信息
        /// </summary>
        /// <returns></returns>
        public int PostCp_Comment(CP_Comment m)
        {
            return dal.PostCp_Comment(m); 
        }
        /// <summary>
        /// 删除评论信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCp_Comment(string id)
        {
            return dal.DeleteCp_Comment(id);
        }
        /// <summary>
        /// 修改评论信息
        /// </summary>
        /// <returns></returns>
        public int PutCp_Comment(CP_Comment m)
        {
            return dal.PutCp_Comment(m);
        }
    }
}
