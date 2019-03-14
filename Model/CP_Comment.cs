using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 评论表(CP_Comment)
    /// </summary>
    public class CP_Comment
    {
        /// <summary>
        /// 主键、自增 评论编号
        /// </summary>
        public int C_Id { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string C_Name { get; set; }
        /// <summary>
        /// 评论信息
        /// </summary>
        public string C_Describe { get; set; }
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