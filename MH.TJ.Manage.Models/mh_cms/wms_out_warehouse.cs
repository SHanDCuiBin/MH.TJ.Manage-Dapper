

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 出库单
    /// </summary>
    public class wms_out_warehouse
    {
        /// <summary>
        /// 出库单
        /// </summary>
        public wms_out_warehouse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 出库单号
        /// </summary>
        public System.String out_code { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public System.String batch_no { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32 products_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? count { get; set; }

        /// <summary>
        /// 用途(大类 id)
        /// </summary>
        public System.Int32? purpose_id { get; set; }

        /// <summary>
        /// 出库方式
        /// </summary>
        public System.String out_way { get; set; }

        /// <summary>
        /// 1.销售 2.耗材 3.配件 4.打印纸
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 用户Id (根据type判断)
        /// </summary>
        public System.Int32? client_id { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public System.String client_name { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.Int32? receiveer_id { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        public System.String receiver_name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Single? unit_prices { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public System.Single? total_prices { get; set; }

        /// <summary>
        /// 出库时间
        /// </summary>
        public System.DateTime out_date { get; set; }

        /// <summary>
        /// 外借到期时间
        /// </summary>
        public System.DateTime? until_date { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 库存id
        /// </summary>
        public System.String inventory_id { get; set; }

        /// <summary>
        /// 确认人id
        /// </summary>
        public System.Int32? sure_user_id { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String sure_user_name { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public System.DateTime? produced_date { get; set; }

        /// <summary>
        /// 保质日期
        /// </summary>
        public System.DateTime? expiration_date { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 申请条目的主键
        /// </summary>
        public System.String apply_item_id { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public System.Int32? supplier_id { get; set; }
    }
}