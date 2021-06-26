

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 耗材核算标准表
    /// </summary>
    public class wms_adjust_accounts
    {
        /// <summary>
        /// 耗材核算标准表
        /// </summary>
        public wms_adjust_accounts()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 体检人员类型 1：老年人 2：幼儿园 3：学生
        /// </summary>
        public System.String ry_id { get; set; }

        /// <summary>
        /// 耗材类型
        /// </summary>
        public System.Int32 wms_dict_id { get; set; }

        /// <summary>
        /// 商品信息id
        /// </summary>
        public System.Int32 wms_products_info_id { get; set; }

        /// <summary>
        /// 核算标准
        /// </summary>
        public System.Int32 adjust_accounts { get; set; }

        /// <summary>
        /// 是否禁用   0：禁用。   1  启用。
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime created_date { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime update_date { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        public System.Int32 create_user_id { get; set; }
    }
}