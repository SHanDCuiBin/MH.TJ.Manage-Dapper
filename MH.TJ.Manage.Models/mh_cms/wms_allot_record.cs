

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 调拨记录
    /// </summary>
    public class wms_allot_record
    {
        /// <summary>
        /// 调拨记录
        /// </summary>
        public wms_allot_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 调拨单号
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32 products_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32 count { get; set; }

        /// <summary>
        /// 旧用途(大类 id)
        /// </summary>
        public System.Int32? old_purpose_id { get; set; }

        /// <summary>
        /// 新用途(大类 id)
        /// </summary>
        public System.Int32? new_purpose_id { get; set; }

        /// <summary>
        /// 原仓库
        /// </summary>
        public System.Int32? old_ware { get; set; }

        /// <summary>
        /// 原仓位
        /// </summary>
        public System.Int32? old_place_no { get; set; }

        /// <summary>
        /// 新仓库
        /// </summary>
        public System.Int32? new_ware { get; set; }

        /// <summary>
        /// 新仓位
        /// </summary>
        public System.Int32? new_place_no { get; set; }

        /// <summary>
        /// 出库时间
        /// </summary>
        public System.DateTime allot_date { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 库存id
        /// </summary>
        public System.Int32? inventory_id { get; set; }

        /// <summary>
        /// 借用人id
        /// </summary>
        public System.Int32? borrow_user { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 类型  1.长期 2. 外借3.外借归还4.分配归还
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 外借到期日期
        /// </summary>
        public System.DateTime? until_time { get; set; }

        /// <summary>
        /// 归还日期
        /// </summary>
        public System.DateTime? return_time { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public System.String borrow_client { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public System.String borrow_client_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String product_name { get; set; }

        /// <summary>
        /// 旧仓库名
        /// </summary>
        public System.String old_ware_name { get; set; }

        /// <summary>
        /// 新仓库名
        /// </summary>
        public System.String new_ware_name { get; set; }

        /// <summary>
        /// 旧货架位置
        /// </summary>
        public System.String old_place { get; set; }

        /// <summary>
        /// 新货架位置
        /// </summary>
        public System.String new_place { get; set; }

        /// <summary>
        /// 旧用途
        /// </summary>
        public System.String old_use_way { get; set; }

        /// <summary>
        /// 新用途
        /// </summary>
        public System.String new_use_way { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 借用人
        /// </summary>
        public System.String borrow_user_name { get; set; }

        /// <summary>
        /// 确认人id
        /// </summary>
        public System.Int32? sure_user_id { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String sure_user_name { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 申请条目的主键
        /// </summary>
        public System.String apply_item_id { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.Int32? receiver_id { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        public System.String receiver_name { get; set; }
    }
}