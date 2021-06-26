

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 
    /// </summary>
    public class cms_chamber
    {
        /// <summary>
        /// 
        /// </summary>
        public cms_chamber()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public System.DateTime? start_date { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.DateTime? end_date { get; set; }

        /// <summary>
        /// 会议主题
        /// </summary>
        public System.String the_theme { get; set; }

        /// <summary>
        /// 会议内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.Int32? petitioner { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public System.Int32? reviewers { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 会议室名称 1.大会议室 2.小会议室
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 与会人数
        /// </summary>
        public System.String num { get; set; }

        /// <summary>
        /// 申请人姓名
        /// </summary>
        public System.String petitioner_name { get; set; }

        /// <summary>
        /// 审批人姓名
        /// </summary>
        public System.String reviewers_name { get; set; }

        /// <summary>
        /// 状态 1.待审核 2通过 3.驳回
        /// </summary>
        public System.String state { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        public System.String reason { get; set; }
    }
}