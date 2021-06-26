

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 开票管理人数统计子表
    /// </summary>
    public class cms_tj_out_ticket_number
    {
        /// <summary>
        /// 开票管理人数统计子表
        /// </summary>
        public cms_tj_out_ticket_number()
        {
        }

        /// <summary>
        /// 主键，UUID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 所属的开票ID
        /// </summary>
        public System.String parent_id { get; set; }

        /// <summary>
        /// 统计名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 我方统计人数
        /// </summary>
        public System.Int32? mh_value { get; set; }

        /// <summary>
        /// 院方统计人数
        /// </summary>
        public System.Int32? hospital_value { get; set; }
    }
}