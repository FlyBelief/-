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
    public class CP_IndentBLL
    {
        CP_IndentDAL dal = new CP_IndentDAL();
        /// <summary>
        /// 显示订单表信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCP_Indent()
        {
            return dal.GetCP_Indent();
        }
        /// <summary>
        /// 添加订单表信息
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public int PostCP_Indent(CP_Indent In)
        {
            return dal.PostCP_Indent(In);
        }
        /// <summary>
        /// 删除订单表的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCP_Indent(string id)
        {
            return dal.DeleteCP_Indent(id);
        }
        /// <summary>
        /// 修改订单表的信息
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public int PutCP_Indent(CP_Indent In)
        {
            return dal.PutCP_Indent(In);
        }
    }
}
