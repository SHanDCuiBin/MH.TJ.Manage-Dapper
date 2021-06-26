

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修记录子表（备件信息）
    /// </summary>
    public class mms_maintenance_record_item
    {
        /// <summary>
        /// 维修记录子表（备件信息）
        /// </summary>
        public mms_maintenance_record_item()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 内部
        /// </summary>
        public System.String maintenance_id { get; set; }

        /// <summary>
        /// 备件id
        /// </summary>
        public System.Int32? reserve_id { get; set; }

        /// <summary>
        /// 备件名称
        /// </summary>
        public System.String reserve_name { get; set; }

        /// <summary>
        /// 是否退回仓库1.是2.不是
        /// </summary>
        public System.Int32? is_back { get; set; }
    }
}