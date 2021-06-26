

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 财务电子报销系统报销申请表
    /// </summary>
    public class ers_reimbursement_apply
    {
        /// <summary>
        /// 财务电子报销系统报销申请表
        /// </summary>
        public ers_reimbursement_apply()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 月度
        /// </summary>
        public System.String month { get; set; }

        /// <summary>
        /// 事由
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 公司抬头
        /// </summary>
        public System.String company_letterhead { get; set; }

        /// <summary>
        /// 报销人id
        /// </summary>
        public System.Int32 apply_user_id { get; set; }

        /// <summary>
        /// 报销人姓名
        /// </summary>
        public System.String apply_user_name { get; set; }

        /// <summary>
        /// 报销部门
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 报销部门
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 收款账户姓名
        /// </summary>
        public System.String collection_name { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        public System.String collection_bank { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public System.String collection_card { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public System.String approval_user_id { get; set; }

        /// <summary>
        /// 审批人姓名
        /// </summary>
        public System.String approval_user_name { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public System.String copy_user_id { get; set; }

        /// <summary>
        /// 抄送人姓名
        /// </summary>
        public System.String copy_user_name { get; set; }

        /// <summary>
        /// 状态0.未提交1.已提交2.审批中3.审批完成4.已拒绝5.已撤销6.已销毁
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 总计金额
        /// </summary>
        public System.Double money { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 提交日期
        /// </summary>
        public System.DateTime? submit_time { get; set; }

        /// <summary>
        /// 批准日期
        /// </summary>
        public System.DateTime? approval_time { get; set; }

        /// <summary>
        /// 说明（拒绝原因）
        /// </summary>
        public System.String msg { get; set; }

        /// <summary>
        /// 凭证编号
        /// </summary>
        public System.String proof_code { get; set; }

        /// <summary>
        /// 钉钉审批流id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 实报金额
        /// </summary>
        public System.Double? real_money { get; set; }

        /// <summary>
        /// 原借款金额
        /// </summary>
        public System.Double? yborrow_money { get; set; }
    }
}