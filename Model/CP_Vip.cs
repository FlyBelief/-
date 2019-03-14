using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 8. Vip表(CP_Vip) 
    /// </summary>
    public class CP_Vip
    {
        /// <summary>
        /// 主键、自增 Vip编号
        /// </summary>
        public int V_Id { get; set; }
        /// <summary>
        /// Vip图片路径
        /// </summary>
        public string V_Path { get; set; }
        /// <summary>
        /// Vip名称
        /// </summary>
        public string V_Name { get; set; }

    }
}
