using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 小区表(CP_SmallSanjak) 
    /// </summary>
    public class CP_SmallSanjak
    {
        /// <summary>
        /// 主键、自增 小区份编号
        /// </summary>
        public int SS_Id { get; set; }
        /// <summary>
        /// 小区份名称
        /// </summary>
        public int SS_Name { get; set; }
        /// <summary>
        /// 区份编号
        /// </summary>
        public int S_Id { get; set; }
    }
}
