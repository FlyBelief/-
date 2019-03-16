using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public class CP_ProvinceBll
    {
        CP_ProvinceDal dal = new CP_ProvinceDal();
        /// <summary>
        /// 省份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_ProvinceAdd(CP_Province add)
        {
            return dal.CP_ProvinceAdd(add);
        }
        /// <summary>
        /// 省份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_ProvinceShow()
        {
            return dal.CP_ProvinceShow();
        }
        /// <summary>
        /// 省份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_ProvinceDel(int id)
        {
            return dal.CP_ProvinceDel(id);
        }
        /// <summary>
        /// 省份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_ProvinceUpdate(CP_Province update)
        {
            return dal.CP_ProvinceUpdate(update);
        }
    }
}
