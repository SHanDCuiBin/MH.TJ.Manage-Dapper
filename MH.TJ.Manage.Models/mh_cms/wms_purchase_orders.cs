

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 采购订单详情表
    /// </summary>
    public class wms_purchase_orders
    {
        /// <summary>
        /// 采购订单详情表
        /// </summary>
        public wms_purchase_orders()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 订单编号,用于判断同一订单
        /// </summary>
        public System.String orders_code { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32 products_id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public System.Int32? count { get; set; }

        /// <summary>
        /// 采购数量
        /// </summary>
        public System.Int32? purchase_count { get; set; }

        /// <summary>
        /// 用途(大类 id)
        /// </summary>
        public System.Int32? purpose_id { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public System.String use_way { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit_str { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Single? unit_prices { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public System.Single? total_prices { get; set; }

        /// <summary>
        /// 供货商
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        public System.DateTime? order_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 退货状态 ：0 正常 1：退货退款。2：仅退款。3：换货
        /// </summary>
        public System.Int32? return_type { get; set; }
    }
}