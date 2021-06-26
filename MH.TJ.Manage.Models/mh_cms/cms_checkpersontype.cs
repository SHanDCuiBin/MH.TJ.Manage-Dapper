

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 健康体检 人员类型表
    /// </summary>
    public class cms_checkpersontype
    {
        /// <summary>
        /// 健康体检 人员类型表
        /// </summary>
        public cms_checkpersontype()
        {
        }

        /// <summary>
        /// 主键  编号
        /// </summary>
        public System.String ry_id { get; set; }

        /// <summary>
        /// 人员类型标号
        /// </summary>
        public System.Int32? ry_type { get; set; }

        /// <summary>
        /// 人员类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 收费状态   0/null 收费    1免费
        /// </summary>
        public System.String type_fufei { get; set; }

        /// <summary>
        /// 人员类型描述
        /// </summary>
        public System.String type_msg { get; set; }

        /// <summary>
        /// 人员类型备注
        /// </summary>
        public System.String type_remark { get; set; }

        /// <summary>
        /// 人员类型对应的机构级别
        /// </summary>
        public System.Int32? org_level { get; set; }
    }
}