

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 库存物品模块表
    /// </summary>
    public class wms_inv_mod
    {
        /// <summary>
        /// 库存物品模块表
        /// </summary>
        public wms_inv_mod()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public System.Int32? tmp_id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String tmp_name { get; set; }

        /// <summary>
        /// 库存id
        /// </summary>
        public System.Int32? inv_id { get; set; }

        /// <summary>
        /// 物品id
        /// </summary>
        public System.Int32? product_id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public System.Int32? count { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 仓库(车辆)Id
        /// </summary>
        public System.Int32? war_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String update_user_name { get; set; }
    }
}