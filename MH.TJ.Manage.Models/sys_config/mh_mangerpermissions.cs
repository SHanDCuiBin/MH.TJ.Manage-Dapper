

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 模块权限分配表
    /// </summary>
    public class mh_mangerpermissions
    {
        /// <summary>
        /// 模块权限分配表
        /// </summary>
        public mh_mangerpermissions()
        {
        }

        /// <summary>
        /// 授权编号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 被授权人编号
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 被授权人姓名
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 模块id   mh_magermodule表id字段
        /// </summary>
        public System.String module_id { get; set; }

        /// <summary>
        /// 模块名称 mh_magermodule表moduleName字段
        /// </summary>
        public System.String moduleName { get; set; }

        /// <summary>
        /// 是否允许 允许1/ 不允许0
        /// </summary>
        public System.String permission { get; set; }

        /// <summary>
        /// 授权人id
        /// </summary>
        public System.String authorizer_id { get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        public System.DateTime? authorization_time { get; set; }
    }
}