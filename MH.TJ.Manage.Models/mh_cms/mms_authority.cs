

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修权限表
    /// </summary>
    public class mms_authority
    {
        /// <summary>
        /// 维修权限表
        /// </summary>
        public mms_authority()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 维修工程师姓名
        /// </summary>
        public System.String service_name { get; set; }

        /// <summary>
        /// 维修工程师id
        /// </summary>
        public System.Int32? service_id { get; set; }

        /// <summary>
        /// 负责部门
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 负责部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}