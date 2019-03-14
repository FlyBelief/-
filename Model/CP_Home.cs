using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 房源表(CP_Home)
    /// </summary>
    public class CP_Home
    {
        /// <summary>
        /// 主键、自增 房源编号
        /// </summary>
        public int H_Id { get; set; }
        /// <summary>
        /// 房源名称
        /// </summary>
        public string H_Name { get; set; }
        /// <summary>
        /// 出租1或出售2
        /// </summary>
        public int H_RentSale { get; set; }
        /// <summary>
        /// 整套1或单间2
        /// </summary>
        public int H_OneTwo { get; set; }
        /// <summary>
        /// 	省份编号
        /// </summary>
        public int P_Id { get; set; }
        /// <summary>
        /// 区份编号
        /// </summary>
        public int S_Id { get; set; }
        /// <summary>
        /// 小区份编号
        /// </summary>
        public int SS_Id { get; set; }
        /// <summary>
        /// 几室
        /// </summary>
        public int H_Room { get; set; }
        /// <summary>
        /// 几厅
        /// </summary>
        public int H_Offic { get; set; }
        /// <summary>
        /// 几卫
        /// </summary>
        public int H_Toilet { get; set; }
        /// <summary>
        /// 房产面积
        /// </summary>
        public float H_Acreage { get; set; }
        /// <summary>
        /// 装修情况
        /// </summary>
        public string H_Decoration { get; set; }
        /// <summary>
        /// 第几层
        /// </summary>
        public int H_Now { get; set; }
        /// <summary>
        /// 共几层
        /// </summary>
        public int H_Sum { get; set; }
        /// <summary>
        /// 有无电梯
        /// </summary>
        public int H_IsNot { get; set; }
        /// <summary>
        /// 有无车位
        /// </summary>
        public int H_Stall { get; set; }
        /// <summary>
        /// 租金/月
        /// </summary>
        public float H_Rent { get; set; }
        /// <summary>
        /// 租金类型
        /// </summary>
        public int H_RentInfo { get; set; }
        /// <summary>
        /// 看房时间
        /// </summary>
        public DateTime H_ShowingTime { get; set; }
        /// <summary>
        /// 最早入住时间
        /// </summary>
        public DateTime H_SoonestTime { get; set; }
        /// <summary>
        /// 房源描述
        /// </summary>
        public int H_Describe { get; set; }
        /// <summary>
        /// 置顶天数
        /// </summary>
        public int H_Stick { get; set; }
        /// <summary>
        /// 刷新天数
        /// </summary>
        public int H_Refresh { get; set; }
        /// <summary>
        /// 售价
        /// </summary>
        public int H_SumPrice { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public int H_Phone { get; set; }
        /// <summary>
        /// 称呼
        /// </summary>
        public int H_Call { get; set; }
        /// <summary>
        /// 是1,否2
        /// </summary>
        public int H_IsSell { get; set; }
        /// <summary>
        /// 楼盘(无为0)
        /// </summary>
        public int HH_Id { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int U_Id { get; set; }
    }
}
