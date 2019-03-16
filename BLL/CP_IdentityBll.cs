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
  public  class CP_IdentityBll
    {
        CP_IdentityDal dal = new CP_IdentityDal();
        /// <summary>
        /// 身份表添加
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        public int CP_IdentityAdd(CP_Identity add)
        {
            return dal.CP_IdentityAdd(add);
        }
        /// <summary>
        /// 身份表显示
        /// </summary>
        /// <returns></returns>
        public DataTable CP_IdentityShow()
        {
            return dal.CP_IdentityShow();
        }
        /// <summary>
        /// 身份表删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int CP_IdentityDel(int id)
        {
            return dal.CP_IdentityDel(id);
        }
        /// <summary>
        /// 身份表修改
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        public int CP_IdentityUpdate(CP_Identity update)
        {
            return dal.CP_IdentityUpdate(update);
        }
    }
}
