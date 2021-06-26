

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 绩效操作记录表
    /// </summary>
    public class cms_performance_record
    {
        /// <summary>
        /// 绩效操作记录表
        /// </summary>
        public cms_performance_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public System.DateTime operating_date { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public System.String operating_type { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 绩效表id
        /// </summary>
        public System.String performance_id { get; set; }

        /// <summary>
        /// 操作记录说明
        /// </summary>
        public System.String operating_msg { get; set; }
    }
}