

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 仓位管理
    /// </summary>
    public class wms_warehouse_space
    {
        /// <summary>
        /// 仓位管理
        /// </summary>
        public wms_warehouse_space()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public System.Int32 warehouse_id { get; set; }

        /// <summary>
        /// 货架号
        /// </summary>
        public System.Int32? storage_rack_no { get; set; }

        /// <summary>
        /// 仓位号
        /// </summary>
        public System.Int32? position_no { get; set; }

        /// <summary>
        /// 是否有货(1.有货 0.没有货 默认0)
        /// </summary>
        public System.Int32? is_full { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }
    }
}