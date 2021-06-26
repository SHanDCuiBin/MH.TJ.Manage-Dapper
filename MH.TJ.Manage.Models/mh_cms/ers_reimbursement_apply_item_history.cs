

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 财务电子报销系统报销历史申请费用详情表（中间表）
    /// </summary>
    public class ers_reimbursement_apply_item_history
    {
        /// <summary>
        /// 财务电子报销系统报销历史申请费用详情表（中间表）
        /// </summary>
        public ers_reimbursement_apply_item_history()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 费用记录id
        /// </summary>
        public System.String expense_id { get; set; }

        /// <summary>
        /// 报销申请id
        /// </summary>
        public System.String apply_id { get; set; }
    }
}