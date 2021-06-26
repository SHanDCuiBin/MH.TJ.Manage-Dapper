

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 开票管理机构全称对应表
    /// </summary>
    public class cms_tj_out_ticket_organization
    {
        /// <summary>
        /// 开票管理机构全称对应表
        /// </summary>
        public cms_tj_out_ticket_organization()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 对应的机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 开票使用的名称
        /// </summary>
        public System.String full_org_name { get; set; }

        /// <summary>
        /// 0.启用1.禁用
        /// </summary>
        public System.Int32 enable { get; set; }
    }
}