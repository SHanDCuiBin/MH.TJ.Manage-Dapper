

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 体检配置文件信息表
    /// </summary>
    public class ini_table
    {
        /// <summary>
        /// 体检配置文件信息表
        /// </summary>
        public ini_table()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public System.String projectname { get; set; }

        /// <summary>
        /// 配置文件版本号
        /// </summary>
        public System.String versionnum { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public System.String createusername { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 启用状态：0，未启用；1,启用
        /// </summary>
        public System.String enable { get; set; }
    }
}