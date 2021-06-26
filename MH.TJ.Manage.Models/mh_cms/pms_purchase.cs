

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购订单表
    /// </summary>
    public class pms_purchase
    {
        /// <summary>
        /// 采购订单表
        /// </summary>
        public pms_purchase()
        {
        }

        /// <summary>
        /// 主键：采购订单表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 采购编号
        /// </summary>
        public System.String purchase_num { get; set; }

        /// <summary>
        /// 预购人id
        /// </summary>
        public System.Int32? yg_men_id { get; set; }

        /// <summary>
        /// 预购人name
        /// </summary>
        public System.String yg_men_name { get; set; }

        /// <summary>
        /// 预购人部门id
        /// </summary>
        public System.Int32? yg_men_dept { get; set; }

        /// <summary>
        /// 预购人部门名称
        /// </summary>
        public System.String yg_men_dept_name { get; set; }

        /// <summary>
        /// 预购日期
        /// </summary>
        public System.DateTime? yg_time { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商name
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 产品name
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 采购金额
        /// </summary>
        public System.Decimal? money { get; set; }

        /// <summary>
        /// 采购日期
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 付款方式：0 公对公付款；1 垫付
        /// </summary>
        public System.Int32? pay_method { get; set; }

        /// <summary>
        /// 结算方式：0 年结；1 季度结；2 月结； 3 现结
        /// </summary>
        public System.Int32? settle_method { get; set; }

        /// <summary>
        /// 收票计划：货到收票
        /// </summary>
        public System.Int32? ticket_method { get; set; }

        /// <summary>
        /// 其它收票计划
        /// </summary>
        public System.String other { get; set; }

        /// <summary>
        /// 结算状态：0 已付款；1 未付款
        /// </summary>
        public System.Int32? settle_status { get; set; }

        /// <summary>
        /// 状态：
        ///5 已驳回、
        ///6 未采购、
        ///7 采购中
        ///8 未入库、
        ///9 部分入库、
        ///10 入库完成
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 1 保存；2 提交
        /// </summary>
        public System.Int32? flag { get; set; }

        /// <summary>
        /// 发票状态：0 不可查看；1 可查看
        /// </summary>
        public System.Int32? invoice_status { get; set; }

        /// <summary>
        /// 采购人id
        /// </summary>
        public System.Int32? cg_men_id { get; set; }

        /// <summary>
        /// 采购人name
        /// </summary>
        public System.String cg_men_name { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        public System.String invoice_no { get; set; }

        /// <summary>
        /// 发票类型：
        /// </summary>
        public System.String invoice_type { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        public System.Decimal? invoice_amount { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        public System.Decimal? amount_payable { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        public System.Decimal? actually_paid { get; set; }

        /// <summary>
        /// 未付金额
        /// </summary>
        public System.Decimal? outstanding_amount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public System.Decimal? tax_rate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? founder { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? reviser { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remarks { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }
    }
}