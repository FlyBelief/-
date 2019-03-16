using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Model;
using BLL;
namespace CentralPlains_API.Controllers
{
    public class TPK_APIController : ApiController //田朋凯
    {

        TPK_BLL bll = new TPK_BLL();

        
        #region 区分表
        [HttpDelete]
        public DataTable DeleDifferentiate(int id) //删除区分表
        {
            return bll.DeleDifferentiate(id);
        }
        [HttpGet]
        public DataTable FanDifferentiate(int id) //反添区分表
        {

            return bll.FanDifferentiate(id);
        }
        [HttpGet]
        public DataTable GetDifferentiate() //显示区分表
        {
            return bll.GetDifferentiate();
        }
        [HttpPost]
        public int AddDifferentiate(CP_Sanjak c)//添加区分表
        {
            return bll.AddDifferentiate(c);
        }
        [HttpPut]
        public int PutDifferentiate(CP_Sanjak c)//修改区分表
        {
            return bll.PutDifferentiate(c);
        }
        #endregion



        #region  小区表

        [HttpDelete]
        public DataTable DeleCampus(int id) //删除小区表
        {
            return bll.DeleCampus(id);
        }
        [HttpGet]
        public DataTable GetCampus() //显示小区表
        {
            return bll.GetCampus();
        }
        [HttpPost]
        public int AddCampus(CP_SmallSanjak c)//添加小区分表
        {
            return bll.AddCampus(c);
        }
        [HttpPut]
        public int PutCampus(CP_SmallSanjak c)//修改小区分表
        {
            return bll.PutCampus(c);
        }
        [HttpGet]
        public DataTable FanCampus(int id) //反添小区表
        {
            return bll.FanCampus(id);
        }

        #endregion


        #region 图片表
        [HttpDelete]
        public DataTable DelePicture(int id) //反添小区表
        {
            return bll.DelePicture(id);
        }

        [HttpGet]
        public DataTable GetPicture() //显示图片表
        {
            return bll.GetPicture();
        }
        [HttpPost]
        public int AddPicture(CP_Pictures c)//添加小区分表
        {
            return bll.AddPicture(c);
        }
        [HttpPut]
        public int PutPicture(CP_Pictures c)//修改小区分表
        {
            return bll.PutPicture(c);
        }
        [HttpGet]
        public DataTable FanPicture(int id) //反添小区表
        {
            return bll.FanPicture(id);
        }

        #endregion


    }
}
