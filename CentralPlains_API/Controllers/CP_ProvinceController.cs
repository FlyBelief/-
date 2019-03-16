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
    public class CP_ProvinceController : ApiController
    {
        CP_ProvinceBll bll = new CP_ProvinceBll();
        /// <summary>
        /// 省份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_ProvinceAdd(CP_Province add)
        {
            return bll.CP_ProvinceAdd(add);
        }
        /// <summary>
        /// 省份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_ProvinceShow()
        {
            return bll.CP_ProvinceShow();
        }
        /// <summary>
        /// 省份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_ProvinceDel(int id)
        {
            return bll.CP_ProvinceDel(id);
        }
        /// <summary>
        /// 省份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_ProvinceUpdate(CP_Province update)
        {
            return bll.CP_ProvinceUpdate(update);
        }
    }
}
