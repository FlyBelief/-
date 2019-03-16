using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace CentralPlains_API.Controllers
{
    public class CP_HomeController : ApiController
    {
        CP_HomeBll dal = new CP_HomeBll();
        /// <summary>
        /// 添加房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddHome(CP_Home h)
        {
            return dal.AddHome(h);
        }
        /// <summary>
        /// 查看房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpGet]
        public DataTable LookHome()
        {
            return dal.LookHome();
        }
        /// <summary>
        /// 删除房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DelHome(int id)
        {
            return dal.DelHome(id);
        }
    }
}
