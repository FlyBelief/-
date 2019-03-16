using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace CentralPlains_API.Controllers
{
    public class CP_UsersController : ApiController
    {
        CP_UsersBll bll = new CP_UsersBll();
        /// <summary>
        /// 用户表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_UsersAdd(CP_Users add)
        {
            return bll.CP_UsersAdd(add);
        }
        /// <summary>
        /// 用户表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_UsersShow()
        {
            return bll.CP_UsersShow();
        }
        /// <summary>
        /// 用户表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_UsersDel(int id)
        {
            return bll.CP_UsersDel(id);
        }
        /// <summary>
        /// 用户表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_UsersUpdate(CP_Users update)
        {
            return bll.CP_UsersUpdate(update);
        }
    }
}
