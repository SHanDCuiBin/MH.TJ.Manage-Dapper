

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 
    /// </summary>
    public class ers_expense_record_img_history
    {
        /// <summary>
        /// 
        /// </summary>
        public ers_expense_record_img_history()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 发票图片
        /// </summary>
        public System.String invoice_img { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 费用类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 是否有发票（1：有发票，2：无发票）
        /// </summary>
        public System.Int32? is_invoice { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_id { get; set; }

        /// <summary>
        /// 状态0.未报销1.已选择2.审批中3.审批完成
        /// </summary>
        public System.Int32? state { get; set; }
    }
}