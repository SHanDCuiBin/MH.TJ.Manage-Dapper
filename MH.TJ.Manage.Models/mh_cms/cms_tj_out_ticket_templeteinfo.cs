

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 开票管理模板子表
    /// </summary>
    public class cms_tj_out_ticket_templeteinfo
    {
        /// <summary>
        /// 开票管理模板子表
        /// </summary>
        public cms_tj_out_ticket_templeteinfo()
        {
        }

        /// <summary>
        /// 主键ID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 对应模板表的id
        /// </summary>
        public System.String parent_id { get; set; }

        /// <summary>
        /// 对应人员类型表的id(-1代表全部类型)
        /// </summary>
        public System.Int32? type_id { get; set; }

        /// <summary>
        /// 人员类型的名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 体检类型
        /// </summary>
        public System.String tj_type { get; set; }

        /// <summary>
        /// 起始年龄
        /// </summary>
        public System.Int32? age_start { get; set; }

        /// <summary>
        /// 起始年龄的符号（>= 或者>）
        /// </summary>
        public System.String age_startchar { get; set; }

        /// <summary>
        /// 终止年龄
        /// </summary>
        public System.Int32? age_end { get; set; }

        /// <summary>
        /// 终止年龄的符号（<=或者<）
        /// </summary>
        public System.String age_endchar { get; set; }

        /// <summary>
        /// 启用禁用（0否 1是）
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 社区名字
        /// </summary>
        public System.String community { get; set; }

        /// <summary>
        /// 社区id
        /// </summary>
        public System.String community_id { get; set; }

        /// <summary>
        /// 特殊项目
        /// </summary>
        public System.String special_project { get; set; }

        /// <summary>
        /// 特殊项目id
        /// </summary>
        public System.Int32? special_project_id { get; set; }

        /// <summary>
        /// 区id
        /// </summary>
        public System.String orgId { get; set; }

        /// <summary>
        /// 市区名字
        /// </summary>
        public System.String orgName { get; set; }

        /// <summary>
        /// 顺序字段
        /// </summary>
        public System.Int32? num { get; set; }
    }
}