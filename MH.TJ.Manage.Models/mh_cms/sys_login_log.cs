

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统登录记录
    /// </summary>
    public class sys_login_log
    {
        /// <summary>
        /// 系统登录记录
        /// </summary>
        public sys_login_log()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 日志名称
        /// </summary>
        public System.String logname { get; set; }

        /// <summary>
        /// 管理员id
        /// </summary>
        public System.Int32? userid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 是否执行成功
        /// </summary>
        public System.String succeed { get; set; }

        /// <summary>
        /// 具体消息
        /// </summary>
        public System.String message { get; set; }

        /// <summary>
        /// 登录ip
        /// </summary>
        public System.String ip { get; set; }
    }
}