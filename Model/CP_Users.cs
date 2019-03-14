using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class CP_Users
    {
        /// <summary>
        /// 主键、自增 用户编号
        /// </summary>
        public int U_Id { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string U_Name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string U_PassWord { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public int U_Phone { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string U_TName { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string U_IDCard { get; set; }
        /// <summary>
        /// 信用积分
        /// </summary>
        public int U_CreditScore { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string U_Icon { get; set; }
        /// <summary>
        /// Vip编号
        /// </summary>
        public int V_Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime U_Time { get; set; }
    }
}
