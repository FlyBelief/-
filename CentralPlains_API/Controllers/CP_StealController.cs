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
    public class CP_StealController : ApiController
    {

        CP_StealBLL dal = new CP_StealBLL();

        /// <summary>
        /// 显示盗窃表(CP_Steal) 
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Steal()
        {
            return dal.GetCP_Steal();
        }
        /// <summary>
        /// 添加盗窃信息
        /// </summary>
        /// <returns></returns>
        public int PostCP_Steal(CP_Steal St)
        {
            return dal.PostCP_Steal(St);

        }
        /// <summary>
        /// 删除盗窃信息
        /// </summary>
        /// <returns></returns>
        public int DeleteCP_Steal(string id)
        {
            return dal.DeleteCP_Steal(id);

        }
        /// <summary>
        /// 修改盗窃信息
        /// </summary>
        /// <param name="St"></param>
        /// <returns></returns>
        public int PutCP_Steal(CP_Steal St)
        {
            return dal.PutCP_Steal(St);

        }
    }
}
