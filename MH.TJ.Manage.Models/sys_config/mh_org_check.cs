

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_org_check
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_org_check()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 检验方：迪安、艾迪康
        /// </summary>
        public System.String check_type { get; set; }

        /// <summary>
        /// 检验方名称：迪安，济南艾迪康，青岛艾迪康
        /// </summary>
        public System.String check_name { get; set; }

        /// <summary>
        /// 状态：1：启用；0禁用
        /// </summary>
        public System.Int32? record_status { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 账号（对外开发接口的账号）
        /// </summary>
        public System.String account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public System.String password { get; set; }

        /// <summary>
        /// IP白名单
        /// </summary>
        public System.String ip_whites { get; set; }
    }
}