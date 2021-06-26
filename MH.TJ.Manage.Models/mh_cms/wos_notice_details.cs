

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 通知内容详情表
    /// </summary>
    public class wos_notice_details
    {
        /// <summary>
        /// 通知内容详情表
        /// </summary>
        public wos_notice_details()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 通知内容id
        /// </summary>
        public System.Int64? notice_id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public System.Int32? user_id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 用户查看通知状态：0 未查看；1 已查看
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 查看时间
        /// </summary>
        public System.DateTime? look_time { get; set; }
    }
}