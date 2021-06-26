

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 预购订货单表
    /// </summary>
    public class pms_advance_order
    {
        /// <summary>
        /// 预购订货单表
        /// </summary>
        public pms_advance_order()
        {
        }

        /// <summary>
        /// 主键：预购订货单表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 预购方式（1.采购部采购、2.200元以上自行采购，3.200元以下自行采购）
        /// </summary>
        public System.Int32? method { get; set; }

        /// <summary>
        /// 预购类型（1.办公用品试2.剂耗材3.固定资产4.低值易耗5.配件6.其他）
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 预购人id
        /// </summary>
        public System.Int32? yg_men_id { get; set; }

        /// <summary>
        /// 预购人name
        /// </summary>
        public System.String yg_men_name { get; set; }

        /// <summary>
        /// 预购人部门
        /// </summary>
        public System.Int32? yg_men_dept { get; set; }

        /// <summary>
        /// 预购日期
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 预购金额
        /// </summary>
        public System.Decimal? money { get; set; }

        /// <summary>
        /// 期望交付日期
        /// </summary>
        public System.DateTime? date { get; set; }

        /// <summary>
        /// 预购事由
        /// </summary>
        public System.String reasons { get; set; }

        /// <summary>
        /// 状态：
        ///0 未提交、1 审批中、2 已撤销、3 已拒绝、4 未采购、5 采购中 6 未入库、7 部分入库、8 入库完成、9.已驳回
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 采购人id
        /// </summary>
        public System.Int32? cg_men_id { get; set; }

        /// <summary>
        /// 采购人name
        /// </summary>
        public System.String cg_men_name { get; set; }

        /// <summary>
        /// 全部审批人
        /// </summary>
        public System.String all_reviewers { get; set; }

        /// <summary>
        /// 当前审批人
        /// </summary>
        public System.String current_reviewer { get; set; }

        /// <summary>
        /// 最终审批人
        /// </summary>
        public System.String final_reviewer { get; set; }

        /// <summary>
        /// 附件路径：多个使用半角逗号隔开
        /// </summary>
        public System.String file_path { get; set; }

        /// <summary>
        /// 驳回，申请失败理由
        /// </summary>
        public System.String failure_reasons { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remarks { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? founder { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public System.Int32? reviser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }

        /// <summary>
        /// 钉钉申请时间
        /// </summary>
        public System.DateTime? ding_time { get; set; }

        /// <summary>
        /// 钉钉id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 审批人id
        /// </summary>
        public System.String all_reviewers_id { get; set; }

        /// <summary>
        /// 全部抄送人姓名
        /// </summary>
        public System.String copy_users { get; set; }

        /// <summary>
        /// 全部抄送人id
        /// </summary>
        public System.String copy_user_ids { get; set; }

        /// <summary>
        /// 预购人部门名称
        /// </summary>
        public System.String yg_dept_name { get; set; }
    }
}