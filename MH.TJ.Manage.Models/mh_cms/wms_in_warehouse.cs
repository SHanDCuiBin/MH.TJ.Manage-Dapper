

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 入库单
    /// </summary>
    public class wms_in_warehouse
    {
        /// <summary>
        /// 入库单
        /// </summary>
        public wms_in_warehouse()
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
        /// 入库单号
        /// </summary>
        public System.String in_code { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public System.String batch_no { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? count { get; set; }

        /// <summary>
        /// 用途(大类 id)
        /// </summary>
        public System.Int32? purpose_id { get; set; }

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
        /// 入库时间
        /// </summary>
        public System.DateTime? in_date { get; set; }

        /// <summary>
        /// 商品来源
        /// </summary>
        public System.String source { get; set; }

        /// <summary>
        /// 设备出厂编号
        /// </summary>
        public System.String factory_code { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public System.DateTime? produced_date { get; set; }

        /// <summary>
        /// 保质日期
        /// </summary>
        public System.DateTime? expiration_date { get; set; }

        /// <summary>
        /// 仓库号
        /// </summary>
        public System.Int32? warehouse_id { get; set; }

        /// <summary>
        /// 仓位号
        /// </summary>
        public System.Int32? place_id { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public System.String p_source { get; set; }

        /// <summary>
        /// 回退用户id
        /// </summary>
        public System.String back_user_id { get; set; }

        /// <summary>
        /// 回退人
        /// </summary>
        public System.String back_user_name { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }

        /// <summary>
        /// 用途图
        /// </summary>
        public System.String use_way { get; set; }

        /// <summary>
        /// 供货商
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String warehouse_name { get; set; }

        /// <summary>
        /// 货架仓位号
        /// </summary>
        public System.String storage_position_str { get; set; }

        /// <summary>
        /// 确认人id
        /// </summary>
        public System.Int32? sure_user_id { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String sure_user_name { get; set; }

        /// <summary>
        /// 库存Id
        /// </summary>
        public System.Int32? inventory_id { get; set; }
    }
}