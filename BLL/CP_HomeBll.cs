using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class CP_HomeBll
    {
        CP_HomeDal dal = new CP_HomeDal();
        /// <summary>
        /// 添加房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHome(CP_Home h)
        {
            return dal.AddHome(h);
        }
        /// <summary>
        /// 查看房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public DataTable LookHome()
        {
            return dal.LookHome();
        }
        /// <summary>
        /// 删除房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int DelHome(int id)
        {
            return dal.DelHome(id);
        }
    }
}
