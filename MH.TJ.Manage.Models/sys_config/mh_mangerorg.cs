

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 机构权限管理
    /// </summary>
    public class mh_mangerorg
    {
        /// <summary>
        /// 机构权限管理
        /// </summary>
        public mh_mangerorg()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构类型  老年人 1/幼儿园 2 /中小学生 3
        /// </summary>
        public System.String org_type { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 社区/幼儿园名称
        /// </summary>
        public System.String org_sqname { get; set; }

        /// <summary>
        /// 状态 允许1 /不允许 0
        /// </summary>
        public System.String status { get; set; }

        /// <summary>
        /// 负责人 id     122,133,144
        /// </summary>
        public System.String user_id { get; set; }
    }
}