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
    public class CP_VipBLL
    {
        CP_VipDAL dal = new CP_VipDAL();
        /// <summary>
        /// 显示Vip表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Vip()
        {
            return dal.GetCP_Vip();
        }
        /// <summary>
        /// 添加Vip信息
        /// </summary>
        /// <param name="Vip"></param>
        /// <returns></returns>
        public int PostCP_Vip(CP_Vip Vip)
        {
            return dal.PostCP_Vip(Vip);
        }
        /// <summary>
        /// 删除VIP信息 
        /// </summary>
        /// <returns></returns>
        public int DeleteCP_Vip(string id)
        {
            return dal.DeleteCP_Vip(id);
        }
        /// <summary>
        /// 修改VIP信息 
        /// </summary>
        /// <param name="Vip"></param>
        /// <returns></returns>
        public int PutCP_Vip(CP_Vip Vip)
        {
            return dal.PutCP_Vip(Vip);
        }
    }
}
