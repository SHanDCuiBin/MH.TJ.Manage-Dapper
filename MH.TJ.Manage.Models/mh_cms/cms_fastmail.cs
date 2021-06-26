

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 快递表
    /// </summary>
    public class cms_fastmail
    {
        /// <summary>
        /// 快递表
        /// </summary>
        public cms_fastmail()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 服务机构id
        /// </summary>
        public System.String orgid { get; set; }

        /// <summary>
        /// 责任人id
        /// </summary>
        public System.String senduserid { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.String receiverid { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        public System.String receivername { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public System.String fastmailnum { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 快递类别id
        /// </summary>
        public System.String fasttypeid { get; set; }

        /// <summary>
        /// 类型 1公司  2个人
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public System.Double? weight { get; set; }

        /// <summary>
        /// 价钱
        /// </summary>
        public System.Decimal? price { get; set; }

        /// <summary>
        /// 报告是否反馈 1报告反馈  0未反馈 
        /// </summary>
        public System.String isfeedback { get; set; }

        /// <summary>
        /// 档案反馈状态 0 未反馈  1已反馈
        /// </summary>
        public System.String recordfeedback { get; set; }

        /// <summary>
        /// 反馈，确认日期
        /// </summary>
        public System.DateTime? feedbackDate { get; set; }

        /// <summary>
        /// 档案反馈日期
        /// </summary>
        public System.DateTime? recordBackDate { get; set; }

        /// <summary>
        /// 发送日期
        /// </summary>
        public System.DateTime? senddate { get; set; }

        /// <summary>
        /// 报告交接表图片地址
        /// </summary>
        public System.String reportimage { get; set; }

        /// <summary>
        /// 档案交接表图片地址
        /// </summary>
        public System.String recordimage { get; set; }

        /// <summary>
        /// 其他图片地址
        /// </summary>
        public System.String otherimage { get; set; }

        /// <summary>
        /// 收货人的电话
        /// </summary>
        public System.String receiverphone { get; set; }

        /// <summary>
        /// 发送人姓名
        /// </summary>
        public System.String sendername { get; set; }

        /// <summary>
        /// 快递信息是否作废，0或null正常，1作废
        /// </summary>
        public System.String is_nullify { get; set; }
    }
}