

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 开票管理模板表
    /// </summary>
    public class cms_tj_out_ticket_templete
    {
        /// <summary>
        /// 开票管理模板表
        /// </summary>
        public cms_tj_out_ticket_templete()
        {
        }

        /// <summary>
        /// 主键ID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 是否禁用（0否 1是）
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32? rank { get; set; }

        /// <summary>
        /// 页面使用区分 0.机构开票模板 1.体检人数统计
        /// </summary>
        public System.Int32? tj_num { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}