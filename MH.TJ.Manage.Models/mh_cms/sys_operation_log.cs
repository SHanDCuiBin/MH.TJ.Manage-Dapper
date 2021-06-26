

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统 操作日志
    /// </summary>
    public class sys_operation_log
    {
        /// <summary>
        /// 系统 操作日志
        /// </summary>
        public sys_operation_log()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        public System.String logtype { get; set; }

        /// <summary>
        /// 日志名称
        /// </summary>
        public System.String logname { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public System.Int32? userid { get; set; }

        /// <summary>
        /// 类名称
        /// </summary>
        public System.String classname { get; set; }

        /// <summary>
        /// 方法名称
        /// </summary>
        public System.String method { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public System.String succeed { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String message { get; set; }
    }
}