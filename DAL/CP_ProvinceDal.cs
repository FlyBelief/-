using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
   public class CP_ProvinceDal
    {
        /// <summary>
        /// 省份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_ProvinceAdd(CP_Province add)
        {
            string sql = string.Format("insert into CP_Users vslues('{0}','{1}')", add.P_Name, add.P_Picyure);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 省份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_ProvinceShow()
        {
            string sql = "select * from CP_Province";
            return DBHelper.GetTable(sql);
        }
        /// <summary>
        /// 省份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_ProvinceDel(int id)
        {
            string sql = "select * from CP_Province where id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 省份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_ProvinceUpdate(CP_Province update)
        {
            string sql = "update CP_Province set P_Name='{0}'，U_Picyure='{1}', where P_Id='{2}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
