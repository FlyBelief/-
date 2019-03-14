using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 图片表(CP_Pictures) 
    /// </summary>
    public class CP_Pictures
    {
        /// <summary>
        /// 主键、自增 图片编号
        /// </summary>
        public int PP_Id { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string PP_Path { get; set; }
        /// <summary>
        /// 房源编号
        /// </summary>
        public int H_Id { get; set; }
        /// <summary>
        /// 楼盘编号
        /// </summary>
        public int HH_Id { get; set; }

    }
}
