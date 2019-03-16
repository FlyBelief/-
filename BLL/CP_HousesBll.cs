using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CP_HousesBll
    {
        CP_HousesDal dal = new CP_HousesDal();
        /// <summary>
        /// 添加楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHouses(CP_Houses h)
        {
            return dal.AddHouses(h);
        }
        /// <summary>
        /// 查看楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public DataTable LookHouses()
        {
            return dal.LookHouses();
        }
        /// <summary>
        /// 删除楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int DelHouses(int id)
        {
            return dal.DelHouses(id);
        }
    }
}
