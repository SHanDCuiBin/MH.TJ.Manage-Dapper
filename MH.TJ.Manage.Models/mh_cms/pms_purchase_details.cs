

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购订单详情表
    /// </summary>
    public class pms_purchase_details
    {
        /// <summary>
        /// 采购订单详情表
        /// </summary>
        public pms_purchase_details()
        {
        }

        /// <summary>
        /// 采购详情表
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 采购编号
        /// </summary>
        public System.String purchase_id { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public System.Int32? warehouse_id { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String warehouse_name { get; set; }

        /// <summary>
        /// 产品类型id
        /// </summary>
        public System.Int32? product_type_id { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public System.String product_type { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public System.String model { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? number { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal? unit_price { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public System.Decimal? total_price { get; set; }

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
    }
}