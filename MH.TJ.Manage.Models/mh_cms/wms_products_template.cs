

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 物品领用清单模板表
    /// </summary>
    public class wms_products_template
    {
        /// <summary>
        /// 物品领用清单模板表
        /// </summary>
        public wms_products_template()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.Int32 ry_type { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 是否是最小单位标记0是，1不是
        /// </summary>
        public System.Int32 tag { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public System.String products_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32 num { get; set; }

        /// <summary>
        /// 类别  1设备2试剂耗材
        /// </summary>
        public System.Int32 flag { get; set; }

        /// <summary>
        /// 上级id
        /// </summary>
        public System.Int32 parent_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public System.String unit { get; set; }
    }
}