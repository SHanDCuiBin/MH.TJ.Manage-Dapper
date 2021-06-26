

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 申请单出库子表
    /// </summary>
    public class wms_application_out_warehouse_detail
    {
        /// <summary>
        /// 申请单出库子表
        /// </summary>
        public wms_application_out_warehouse_detail()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 申请单出库表id
        /// </summary>
        public System.Int32 out_warehouse_id { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public System.String batch_no { get; set; }

        /// <summary>
        /// 实际领用数量
        /// </summary>
        public System.Decimal? get_num { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Single? unit_prices { get; set; }

        /// <summary>
        /// 类型：1耗材  2设备
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public System.Int32 products_id { get; set; }

        /// <summary>
        /// 商品名字
        /// </summary>
        public System.String products_name { get; set; }

        /// <summary>
        /// 整套的模板id
        /// </summary>
        public System.String template_id { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        public System.String template_name { get; set; }

        /// <summary>
        /// 模板数量
        /// </summary>
        public System.Int32? template_num { get; set; }

        /// <summary>
        /// 领用时间
        /// </summary>
        public System.DateTime? get_date { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit_str { get; set; }

        /// <summary>
        /// 供应商名字
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 申请数量
        /// </summary>
        public System.String apply_num { get; set; }

        /// <summary>
        /// 1:完成盘点，2.未盘点
        /// </summary>
        public System.Int32? is_stock { get; set; }
    }
}