using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
namespace DAL
{
   public class TPK_DAL
    {

        #region 区分表

        public DataTable FanDifferentiate(int id) //反添区分表
        {
            string sql = "select * from CP_Sanjak  where S_Id="+id+"";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }
        public DataTable DeleDifferentiate(int id) //删除区分表
        {
            string sql = "delete from CP_Sanjak  where S_Id=" + id + "";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }

        public DataTable GetDifferentiate() //显示区分表
        {
            string sql = "select * from CP_Sanjak ";
           DataTable db= DBHelper.GetTable(sql);
            return db;
        }
        public int AddDifferentiate(CP_Sanjak c)//添加区分表
        {
            string sql =string.Format("insert into CP_Sanjak values('{0}',{1})",c.S_Name, c.P_Id) ;
           int n =DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        public int PutDifferentiate(CP_Sanjak c)//修改区分表
        {
            string sql = string.Format("update from CP_Sanjak set S_Name='{0}',P_Id={1} where S_Id={2}", c.S_Name, c.P_Id,c.S_Id);
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        #endregion



        #region  小区表

        public DataTable FanCampus(int id) //反添小区表
        {
            string sql = "select * from CP_SmallSanjak  where SS_Id=" + id + "";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }
        public DataTable DeleCampus(int id) //删除小区表
        {
            string sql = "delete from CP_SmallSanjak  where SS_Id=" + id + "";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }

        public DataTable GetCampus() //显示小区表
        {
            string sql = "select * from CP_SmallSanjak ";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }
        public int AddCampus(CP_SmallSanjak c)//添加小区分表
        {
            string sql = string.Format("insert into CP_SmallSanjak values('{0}',{1})", c.SS_Name, c.S_Id);
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
       
        public int PutCampus(CP_SmallSanjak c)//修改小区分表
        {
            string sql = string.Format("update from CP_SmallSanjak set SS_Name='{0}',S_Id={1} where SS_Id={2}", c.SS_Name, c.S_Id, c.SS_Id);
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }

        #endregion


        #region 图片表


        public DataTable FanPicture(int id) //反添图片
        {
            string sql = "select * from CP_Pictures  where PP_Id=" + id + "";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }
        public DataTable DelePicture(int id) //删除图片
        {
            string sql = "delete from CP_Pictures  where PP_Id=" + id + "";
            DataTable db = DBHelper.GetTable(sql);
            return db;
        }

        public DataTable GetPicture() //显示图片表
        {
            string sql = "select * from CP_Pictures";
            DataTable DB = DBHelper.GetTable(sql);
            return DB;
        }
        public int AddPicture(CP_Pictures c)//添加图片
        {
            string sql = string.Format("insert into CP_Pictures values('{0}',{1},{2})", c.PP_Path, c.H_Id,c.HH_Id);
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }

        public int PutPicture(CP_Pictures c)//修改图片
        {
            string sql = string.Format("update from CP_Pictures set PP_Path='{0}',H_Id={1},HH_Id={2} where PP_Id={3}", c.PP_Path, c.H_Id, c.HH_Id,c.PP_Id);
            int n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }


        #endregion

    }
}
