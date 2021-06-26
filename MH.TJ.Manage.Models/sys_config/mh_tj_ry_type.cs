

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 【沐华健康体检管理系统】健康体检 人员类型表--记录体检人员类型的信息
    /// </summary>
    public class mh_tj_ry_type
    {
        /// <summary>
        /// 【沐华健康体检管理系统】健康体检 人员类型表--记录体检人员类型的信息
        /// </summary>
        public mh_tj_ry_type()
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
    }
}