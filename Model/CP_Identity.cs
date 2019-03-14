using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 身份表
    /// </summary>
    public class CP_Identity
    {
        /// <summary>
        /// 主键、自增 身份编号
        /// </summary>
        public int I_Id { get; set; }
        /// <summary>
        /// 	身份名称
        /// </summary>
        public string I_Name { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int U_Id { get; set; }
        /// <summary>
        ///  中介公司名称
        /// </summary>
        public string I_BossName { get; set; }

    }
}
