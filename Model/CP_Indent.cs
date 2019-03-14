using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单表(CP_Indent)
    /// </summary>
    public class CP_Indent
    {
        /// <summary>
        /// 主键、自增 订单编号
        /// </summary>
        public int II_Id { get; set; }
        /// <summary>
        /// 	房源编号
        /// </summary>
        public int H_Id { get; set; }
        /// <summary>
        /// 	订单名称
        /// </summary>
        public string II_Name { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime II_Time { get; set; }

    }
}
