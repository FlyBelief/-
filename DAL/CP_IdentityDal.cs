using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
  public  class CP_IdentityDal
    {
        /// <summary>
        /// 身份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_IdentityAdd(CP_Identity add)
        {
            string sql = string.Format("insert into CP_Users vslues('{0}','{1}','{2}')", add.I_Name,add.U_Id, add.I_BossName);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 身份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_IdentityShow()
        {
            string sql = "select * from CP_Identity";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 身份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_IdentityDel(int id)
        {
            string sql = "select * from CP_Identity where id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 身份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_IdentityUpdate(CP_Identity update)
        {
            string sql = "update CP_Identity set I_Name='{0}'，U_Id='{1}',I_BossName='{2}' where I_Id='{3}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
