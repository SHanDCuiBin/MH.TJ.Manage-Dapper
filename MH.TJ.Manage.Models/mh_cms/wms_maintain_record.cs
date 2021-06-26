

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修记录
    /// </summary>
    public class wms_maintain_record
    {
        /// <summary>
        /// 维修记录
        /// </summary>
        public wms_maintain_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 产品Id 对应products_info
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 沐华编号(二维码信息)
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public System.Int32? possessor_id { get; set; }

        /// <summary>
        /// 维修结果
        /// </summary>
        public System.String result { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 维修日期
        /// </summary>
        public System.DateTime maintain_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 备件名称
        /// </summary>
        public System.String bj_name { get; set; }

        /// <summary>
        /// 是否更换备件 1.是 0.否
        /// </summary>
        public System.SByte? change_bj { get; set; }

        /// <summary>
        /// 出厂设备号
        /// </summary>
        public System.String factory_code { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.Int64? sure_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sure_user_name { get; set; }
    }
}