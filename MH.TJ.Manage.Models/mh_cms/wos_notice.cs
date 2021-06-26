

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 通知内容表
    /// </summary>
    public class wos_notice
    {
        /// <summary>
        /// 通知内容表
        /// </summary>
        public wos_notice()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        public System.String notice_content { get; set; }

        /// <summary>
        /// 通知发布开始时间
        /// </summary>
        public System.DateTime? start_time { get; set; }

        /// <summary>
        /// 通知发布结束时间
        /// </summary>
        public System.DateTime? end_time { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? create_user { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }
    }
}