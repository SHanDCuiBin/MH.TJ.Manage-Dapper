

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 数据库链接信息
    /// </summary>
    public class code_dbinfo
    {
        /// <summary>
        /// 数据库链接信息
        /// </summary>
        public code_dbinfo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 数据库驱动
        /// </summary>
        public System.String db_driver { get; set; }

        /// <summary>
        /// 数据库地址
        /// </summary>
        public System.String db_url { get; set; }

        /// <summary>
        /// 数据库账户
        /// </summary>
        public System.String db_user_name { get; set; }

        /// <summary>
        /// 连接密码
        /// </summary>
        public System.String db_password { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public System.String db_type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}