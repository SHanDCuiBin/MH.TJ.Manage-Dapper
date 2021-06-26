

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 库存表
    /// </summary>
    public class wms_inventory
    {
        /// <summary>
        /// 库存表
        /// </summary>
        public wms_inventory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

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
        /// 入库时间
        /// </summary>
        public System.DateTime? in_date { get; set; }

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
        /// 1.在仓库 2.分配 3.借出
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 责任人(持有人)
        /// </summary>
        public System.Int32? possessor_id { get; set; }

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
        /// 商品名称
        /// </summary>
        public System.String products_name { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String warehouse_name { get; set; }

        /// <summary>
        /// 货架仓位号
        /// </summary>
        public System.String storage_position_str { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit_str { get; set; }

        /// <summary>
        /// 外借到期日期
        /// </summary>
        public System.DateTime? until_time { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public System.String possessor_name { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public System.String specifications { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        public System.String use_way { get; set; }

        /// <summary>
        /// 供货商
        /// </summary>
        public System.Int32? supplier_id { get; set; }

        /// <summary>
        /// 供货商名字
        /// </summary>
        public System.String supplier_name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Single? price { get; set; }

        /// <summary>
        /// 整套的模板id
        /// </summary>
        public System.String template_id { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        public System.String template_name { get; set; }

        /// <summary>
        /// 申请的模板数量
        /// </summary>
        public System.Int32? template_num { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}