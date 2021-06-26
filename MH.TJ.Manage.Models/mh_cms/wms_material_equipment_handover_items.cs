

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 耗材设备交接从表
    /// </summary>
    public class wms_material_equipment_handover_items
    {
        /// <summary>
        /// 耗材设备交接从表
        /// </summary>
        public wms_material_equipment_handover_items()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 交接主表id
        /// </summary>
        public System.Int32? handover_id { get; set; }

        /// <summary>
        /// 交接类型(1.耗材信息2.设备信息)
        /// </summary>
        public System.Int32? handover_type { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 类型id
        /// </summary>
        public System.Int32? type_id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 交接数量
        /// </summary>
        public System.Decimal? num { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        public System.Int32? business_id { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public System.String business_name { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String barcode { get; set; }

        /// <summary>
        /// 原数量
        /// </summary>
        public System.Decimal? ynum { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal? unit_prices { get; set; }

        /// <summary>
        /// 模板数量
        /// </summary>
        public System.Int32? template_num { get; set; }

        /// <summary>
        /// 出库表id
        /// </summary>
        public System.Int32? out_warehouse_id { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String out_warehouse_name { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public System.Int32? warehouse_id { get; set; }
    }
}