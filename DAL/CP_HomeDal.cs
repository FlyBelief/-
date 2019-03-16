using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class CP_HomeDal
    {
        /// <summary>
        /// 添加房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHome(CP_Home h)
        {
            int i = DBHelper.ExecuteNonQuery($"insert into CP_Home values ('{h.H_Name}',{h.H_RentSale},{h.H_OneTwo},{h.P_Id},{h.S_Id},{h.SS_Id},{h.H_Room},{h.H_Offic},{h.H_Toilet},{h.H_Acreage},'{h.H_Decoration}',{h.H_Now},{h.H_Sum},{h.H_IsNot},{h.H_Stall},{h.H_Rent},{h.H_RentInfo},'{h.H_ShowingTime}','{h.H_SoonestTime}','{h.H_Describe}',{h.H_Stick},{h.H_Refresh},{h.H_SumPrice},'{h.H_Phone}','{h.H_Call}',{h.H_IsSell},{h.HH_Id},{h.U_Id})");
            return i;
        }
        /// <summary>
        /// 查看房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public DataTable LookHome()
        {
            DataTable i = DBHelper.GetTable("select * from CP_Home;");
            return i;
        }
        /// <summary>
        /// 删除房源
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int DelHome(int id)
        {
            int i = DBHelper.ExecuteNonQuery("delete from CP_Home where H_Id="+id);
            return i;
        }
    }
}
