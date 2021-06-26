

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 保养记录
    /// </summary>
    public class wms_upkeep_record
    {
        /// <summary>
        /// 保养记录
        /// </summary>
        public wms_upkeep_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 保养单号
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 保养类型 1.耗材 2.固定资产
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 状态 1.开始 2.结束 3.暂停
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 保养类型 1.普通保养 2.重点保养
        /// </summary>
        public System.SByte by_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? complete_time { get; set; }

        /// <summary>
        /// 完成人
        /// </summary>
        public System.Int32? complete_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String type_str { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ware_str { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ware_house_id { get; set; }
    }
}