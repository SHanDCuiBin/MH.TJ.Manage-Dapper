
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 报告打印量统计
    /// </summary>
    public class mh_jktj_print
    {
        /// <summary>
        /// 报告打印量统计
        /// </summary>
        public mh_jktj_print()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 体检表ID
        /// </summary>
        public System.String tj_id { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.String ry_type { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 上级机构名称
        /// </summary>
        public System.String parent_name { get; set; }

        /// <summary>
        /// 社区名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 每份报告所需纸张数
        /// </summary>
        public System.Int32? dy_page_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? dy_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dy_user_name { get; set; }

        /// <summary>
        /// 打印状态：1、成功 ；2、失败
        /// </summary>
        public System.String dy_state { get; set; }

        /// <summary>
        /// 打印机器名称
        /// </summary>
        public System.String dy_machine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remarks { get; set; }
    }
}