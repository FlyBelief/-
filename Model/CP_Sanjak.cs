using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 区份表(CP_Sanjak) 
    /// </summary>
    public class CP_Sanjak
    {
        /// <summary>
        /// 主键、自增 区份编号
        /// </summary>
        public int S_Id { get; set; }
        /// <summary>
        /// 区份名称
        /// </summary>
        public string S_Name { get; set; }
        /// <summary>
        /// 省编号
        /// </summary>
        public int P_Id { get; set; }

    }
}
