using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CentralPlains_API.Controllers
{
    public class CP_HousesController : ApiController
    {
        CP_HousesBll dal = new CP_HousesBll();
        /// <summary>
        /// 添加楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddHouses(CP_Houses h)
        {
            return dal.AddHouses(h);
        }
        /// <summary>
        /// 查看楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpGet]
        public DataTable LookHouses()
        {
            return dal.LookHouses();
        }
        /// <summary>
        /// 删除楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DelHouses(int id)
        {
            return dal.DelHouses(id);
        }
    }
}
