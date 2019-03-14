using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 盗窃表(CP_Steal) 
    /// </summary>
    public class CP_Steal
    {
        //1	SS_Id Int 主键、自增 盗窃编号
        //2	SS_Name Varchar Not null 	姓名
        //3	SS_Phone Int Not null 	电话号
        //4	SS_Time Datatime    Not null	添加时间
        /// <summary>
        /// 主键、自增 盗窃编号
        /// </summary>
        public int SS_Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string SS_Name { get; set; }
        /// <summary>
        /// 电话号
        /// </summary>
        public int SS_Phone { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime SS_Time { get; set; }
    }
}
