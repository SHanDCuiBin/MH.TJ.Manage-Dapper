

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购系统操作日志表
    /// </summary>
    public class pms_operation_log
    {
        /// <summary>
        /// 采购系统操作日志表
        /// </summary>
        public pms_operation_log()
        {
        }

        /// <summary>
        /// 主键：操作日志表
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public System.String _operator { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public System.String ip_addr { get; set; }

        /// <summary>
        /// 操作信息
        /// </summary>
        public System.String msg { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public System.DateTime operation_time { get; set; }
    }
}