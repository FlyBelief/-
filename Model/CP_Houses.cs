using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 楼盘表(CP_Houses) 
    /// </summary>
    public class CP_Houses
    {
        /// <summary>
        /// 主键、自增 楼盘编号
        /// </summary>
        public int HH_Id { get; set; }
        /// <summary>
        /// 	楼盘图片
        /// </summary>
        public string HH_Path { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string HH_Name { get; set; }
        /// <summary>
        /// 第几层
        /// </summary>
        public int HH_Now { get; set; }
        /// <summary>
        /// 共几层
        /// </summary>
        public int HH_Sum { get; set; }
        /// <summary>
        /// 到几层
        /// </summary>
        public int HH_Low { get; set; }
        /// <summary>
        /// 省份编号 
        /// </summary>
        public int P_Id { get; set; }
        /// <summary>
        ///区份编号 
        /// </summary>
        public int S_Id { get; set; }
        /// <summary>
        /// 小区份编号
        /// </summary>
        public int SS_Id { get; set; }
        /// <summary>
        ///  有无电梯
        /// </summary>
        public int HH_IsNot { get; set; }
        /// <summary>
        /// 有无车位
        /// </summary>
        public int HH_Stall { get; set; }
        /// <summary>
        ///  售价
        /// </summary>
        public float HH_SumPrice { get; set; }
        /// <summary>
        ///  用户编号
        /// </summary>
        public int U_Id { get; set; }
        /// <summary>
        ///  楼盘描述
        /// </summary>
        public string HH_Describe { get; set; }
        /// <summary>
        ///  置顶天数
        /// </summary>
        public int HH_Stick { get; set; }
        /// <summary>
        /// 	刷新天数
        /// </summary>
        public int HH_Refresh { get; set; }
    }
}
