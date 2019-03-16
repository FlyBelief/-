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
   public class TPK_BLL
    {
        TPK_DAL dal = new TPK_DAL();


        #region 区分表


        public DataTable FanDifferentiate(int id) //反添区分表
        {

            return dal.FanDifferentiate(id);
        }
        public DataTable DeleDifferentiate(int id) //删除区分表
        {
            return dal.DeleDifferentiate(id);
        }

        public DataTable GetDifferentiate() //显示区分表
        {
            return dal.GetDifferentiate();
        }
        public int AddDifferentiate(CP_Sanjak c)//添加区分表
        {
            return dal.AddDifferentiate(c);
        }
        public int PutDifferentiate(CP_Sanjak c)//修改区分表
        {
            return dal.PutDifferentiate(c);
        }
        #endregion



        #region  小区表
        public DataTable GetCampus() //显示小区表
        {
            return dal.GetCampus();
        }
        public int AddCampus(CP_SmallSanjak c)//添加小区分表
        {
            return dal.AddCampus(c);
        }

        public int PutCampus(CP_SmallSanjak c)//修改小区分表
        {
            return dal.PutCampus(c);
        }

        public DataTable FanCampus(int id) //反添小区表
        {
            return dal.FanCampus(id);
        }
        public DataTable DeleCampus(int id) //删除小区表
        {
            return dal.DeleCampus(id);
        }
        #endregion


        #region 图片表
        public DataTable GetPicture() //显示图片表
        {
            return dal.GetPicture();
        }

        public int AddPicture(CP_Pictures c)//添加小区分表
        {
            return dal.AddPicture(c);
        }

        public int PutPicture(CP_Pictures c)//修改小区分表
        {
            return dal.PutPicture(c);
        }
        public DataTable FanPicture(int id) //反添小区表
        {
            return dal.FanPicture(id);
        }
        public DataTable DelePicture(int id) //反添小区表
        {
            return dal.DelePicture(id);
        }

        #endregion


    }
}
