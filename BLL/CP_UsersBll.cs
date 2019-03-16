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
   public class CP_UsersBll
    {
        CP_UsersDal dal = new CP_UsersDal();
        /// <summary>
        /// 用户表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_UsersAdd(CP_Users add)
        {
            return dal.CP_UsersAdd(add);
        }
        /// <summary>
        /// 用户表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_UsersShow()
        {
            return dal.CP_UsersShow();
        }
        /// <summary>
        /// 用户表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_UsersDel(int id)
        {
            return dal.CP_UsersDel(id);
        }
        /// <summary>
        /// 用户表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_UsersUpdate(CP_Users update)
        {
            return dal.CP_UsersUpdate(update);
        }
    }
}
