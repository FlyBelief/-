using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 省份表(CP_Province)
    /// </summary>
    public class CP_Province
    {
        /// <summary>
        /// 主键、自增 省份编号
        /// </summary>
        public int P_Id { get; set; }
        /// <summary>
        /// 省份名称
        /// </summary>
        public string P_Name { get; set; }
        /// <summary>
        ///  	省份图片    
        /// </summary>
        public string P_Picyure { get; set; }

    }
}
