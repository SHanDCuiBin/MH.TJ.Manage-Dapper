

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 钉钉配件申请表
    /// </summary>
    public class mms_ding_accessories
    {
        /// <summary>
        /// 钉钉配件申请表
        /// </summary>
        public mms_ding_accessories()
        {
        }

        /// <summary>
        /// uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 申请部门
        /// </summary>
        public System.String depart { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        public System.Int32? proposer_id { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String proposer_name { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String license_number { get; set; }

        /// <summary>
        /// 卫生院
        /// </summary>
        public System.String health_center { get; set; }

        /// <summary>
        /// 配件名称
        /// </summary>
        public System.String parts_name { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 领用详情
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime? date { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public System.String approver_userids { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public System.String copy_userids { get; set; }
    }
}