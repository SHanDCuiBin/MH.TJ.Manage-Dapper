

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 月计划表
    /// </summary>
    public class soc_month_plan
    {
        /// <summary>
        /// 月计划表
        /// </summary>
        public soc_month_plan()
        {
        }

        /// <summary>
        /// ID 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 计划单号(唯一): MHMP201911001
        ///(Mu hua month plan 2019 11 001号计划)
        /// </summary>
        public System.String mp_code { get; set; }

        /// <summary>
        /// 月份 例: ’2019-11’
        /// </summary>
        public System.String month { get; set; }

        /// <summary>
        /// 总项目数(计划数量)
        /// </summary>
        public System.Int32? total_count { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public System.Int32? complete_count { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public System.Int64 create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }
    }
}