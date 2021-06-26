

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 仓库信息
    /// </summary>
    public class wms_warehouse
    {
        /// <summary>
        /// 仓库信息
        /// </summary>
        public wms_warehouse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 管理者 id
        /// </summary>
        public System.Int32? manager_id { get; set; }

        /// <summary>
        /// 1.仓库 2.车辆 3.部门4.报废仓
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 根据type区分 2.车辆ID 3.部门id
        /// </summary>
        public System.String details_code { get; set; }

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