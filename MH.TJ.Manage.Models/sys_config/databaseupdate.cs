

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 数据库升级主表
    /// </summary>
    public class databaseupdate
    {
        /// <summary>
        /// 数据库升级主表
        /// </summary>
        public databaseupdate()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 数据库版本号
        /// </summary>
        public System.String versionnum { get; set; }

        /// <summary>
        /// 创建、添加人
        /// </summary>
        public System.String createusername { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 启用状态：0,禁用；1,启用
        /// </summary>
        public System.String enable { get; set; }
    }
}