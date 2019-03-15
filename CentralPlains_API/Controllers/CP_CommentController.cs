using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BLL;
using Model;

namespace CentralPlains_API.Controllers
{
    public class CP_CommentController : ApiController
    {
        CP_CommentBLL dal = new CP_CommentBLL();
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
