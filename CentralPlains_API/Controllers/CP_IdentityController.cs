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
    public class CP_IdentityController : ApiController
    {
        CP_IdentityBll bll = new CP_IdentityBll();
        /// <summary>
        /// 身份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_IdentityAdd(CP_Identity add)
        {
            return bll.CP_IdentityAdd(add);
        }
        /// <summary>
        /// 身份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_IdentityShow()
        {
            return bll.CP_IdentityShow();
        }
        /// <summary>
        /// 身份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_IdentityDel(int id)
        {
            return bll.CP_IdentityDel(id);
        }
        /// <summary>
        /// 身份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_IdentityUpdate(CP_Identity update)
        {
            return bll.CP_IdentityUpdate(update);
        }
    }
}
