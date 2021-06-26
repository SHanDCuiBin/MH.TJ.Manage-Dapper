

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统服务器表
    /// </summary>
    public class sys_server_manage
    {
        /// <summary>
        /// 系统服务器表
        /// </summary>
        public sys_server_manage()
        {
        }

        /// <summary>
        /// 服务器表主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 数据库用户名
        /// </summary>
        public System.String user { get; set; }

        /// <summary>
        /// 数据库密码
        /// </summary>
        public System.String pass_word { get; set; }

        /// <summary>
        /// 服务器地址
        /// </summary>
        public System.String jdbc_url { get; set; }

        /// <summary>
        /// 服务器连接属性
        /// </summary>
        public System.String connect_attribute { get; set; }

        /// <summary>
        /// 驱动属性
        /// </summary>
        public System.String driver_class { get; set; }

        /// <summary>
        /// 服务器连接名称
        /// </summary>
        public System.String data_source_name { get; set; }
    }
}