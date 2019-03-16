using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CP_HousesDal
    {
        /// <summary>
        /// 添加楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHouses(CP_Houses h)
        {
            int i = DBhelper.ExecuteNonQuery($"insert into CP_Houses values ('{h.HH_Path}','{h.HH_Name}',{h.HH_Sum},{h.P_Id},{h.S_Id},{h.SS_Id},{h.HH_IsNot},{h.HH_Stall},{h.HH_SumPrice},{h.U_Id},'{h.HH_Describe}',{h.HH_Stick},{h.HH_Refresh},'{h.HH_Phone}')");
            return i;
        }
        /// <summary>
        /// 查看楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public DataTable LookHouses()
        {
            DataTable i = DBhelper.GetTable("select * from CP_Houses;");
            return i;
        }
        /// <summary>
        /// 删除楼盘
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int DelHouses(int id)
        {
            int i = DBhelper.ExecuteNonQuery("delete from CP_Houses where HH_Id=" + id);
            return i;
        }
    }
}
