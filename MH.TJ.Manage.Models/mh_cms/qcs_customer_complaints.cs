

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 客户工单客户投诉表
    /// </summary>
    public class qcs_customer_complaints
    {
        /// <summary>
        /// 客户工单客户投诉表
        /// </summary>
        public qcs_customer_complaints()
        {
        }

        /// <summary>
        /// id序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 投诉内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        public System.String img { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public System.String iphone { get; set; }

        /// <summary>
        /// 处理状态（1.待处理 2.已处理，3.误投诉）
        /// </summary>
        public System.UInt32? status { get; set; }

        /// <summary>
        /// 投诉处理人
        /// </summary>
        public System.String deal_user { get; set; }

        /// <summary>
        /// 内部意见
        /// </summary>
        public System.String opinion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 处理日期
        /// </summary>
        public System.DateTime? deal_time { get; set; }

        /// <summary>
        /// 投诉处理人id
        /// </summary>
        public System.Int32? deal_user_id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }
    }
}