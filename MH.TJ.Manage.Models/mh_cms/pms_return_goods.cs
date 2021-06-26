

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 退货表
    /// </summary>
    public class pms_return_goods
    {
        /// <summary>
        /// 退货表
        /// </summary>
        public pms_return_goods()
        {
        }

        /// <summary>
        /// 主键：退货单表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 采购表：采购编号
        /// </summary>
        public System.String purchase_number { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String applicant { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public System.Int32? number { get; set; }

        /// <summary>
        /// 退货原因(方式) 1：产品质量。2：订单不符。3：备注
        /// </summary>
        public System.String return_method { get; set; }

        /// <summary>
        /// 原因备注
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 退货状态 1：未发货。2：已发货。3：已到达
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 产品批号
        /// </summary>
        public System.String product_batch_num { get; set; }

        /// <summary>
        /// 产品规格型号
        /// </summary>
        public System.String model { get; set; }

        /// <summary>
        /// 退货申请日期
        /// </summary>
        public System.DateTime? application_date { get; set; }

        /// <summary>
        /// 退货金额
        /// </summary>
        public System.Decimal? money { get; set; }

        /// <summary>
        /// 对方联系人
        /// </summary>
        public System.String contacts { get; set; }

        /// <summary>
        /// 对方联系人电话
        /// </summary>
        public System.String contact_number { get; set; }

        /// <summary>
        /// 退货方式 1：退货退款。2：仅退款。3：换货
        /// </summary>
        public System.String return_type { get; set; }

        /// <summary>
        /// 对方退货地址
        /// </summary>
        public System.String return_addr { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        public System.String attachment_addr { get; set; }

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
        /// （弃用）退货类型 1：仓库退货。2：采购退货
        /// </summary>
        public System.Int32? return_depart { get; set; }

        /// <summary>
        /// 退款状态 1：已收款。2：未收款
        /// </summary>
        public System.Int32? return_money_type { get; set; }

        /// <summary>
        /// 是否删除 0：禁用 1 正常
        /// </summary>
        public System.Int32? is_delete { get; set; }
    }
}