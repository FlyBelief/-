using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
   public class CP_UsersDal
    {
        /// <summary>
        /// 用户表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_UsersAdd(CP_Users add)
        {
            string sql = string.Format("insert into CP_Users vslues('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",add.U_Name,add.U_PassWord,add.U_Phone,add.U_TName,add.U_IDCard,add.U_CreditScore,add.U_Icon,add.V_Id,add.U_Id,add.U_Time,add.U_day,add.U_Month);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 用户表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_UsersShow()
        {
            string sql = "select * from CP_Users";
            return DBHelper.GetTable(sql);
        }
        /// <summary>
        /// 用户表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_UsersDel(int id)
        {
            string sql = "select * from CP_Users where id="+id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 用户表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_UsersUpdate(CP_Users update)
        {
            string sql = "update CP_Users set U_Name='{0}',U_PassWord='{1}',U_Phone='{2}',U_TName='{3}',U_IDCard='{4}',U_CreditScore='{5}',U_Icon='{6}',V_Id='{7}',U_Time='{8}'U_day='{9}',U_Month='{10}' where U_id='{11}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 身份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_IdentityAdd(CP_Identity add)
        {
            string sql = string.Format("insert into CP_Users vslues('{0}','{1}','{2}')", add.I_Name,add.U_Id,add.I_BossName);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 身份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_IdentityShow()
        {
            string sql = "select * from CP_Identity";
            return DBHelper.GetTable(sql);
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
