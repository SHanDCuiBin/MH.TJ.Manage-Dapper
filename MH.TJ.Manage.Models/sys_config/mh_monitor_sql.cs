

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 监控平台用的sql
    /// </summary>
    public class mh_monitor_sql
    {
        /// <summary>
        /// 监控平台用的sql
        /// </summary>
        public mh_monitor_sql()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        public System.String monitor_type { get; set; }

        /// <summary>
        /// 监控用的sql
        /// </summary>
        public System.String monitor_sql { get; set; }

        /// <summary>
        /// 是否启用 1 启用 0禁用
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}