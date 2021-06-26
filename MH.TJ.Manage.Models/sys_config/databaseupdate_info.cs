

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 数据库升级子表
    /// </summary>
    public class databaseupdate_info
    {
        /// <summary>
        /// 数据库升级子表
        /// </summary>
        public databaseupdate_info()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        public System.String databaseup_id { get; set; }

        /// <summary>
        /// 数据库类型（本地 1、汇总 2） 
        /// </summary>
        public System.String databasetype { get; set; }

        /// <summary>
        /// 要升级的表名
        /// </summary>
        public System.String tablename { get; set; }

        /// <summary>
        /// 执行的sql语句
        /// </summary>
        public System.String executesql { get; set; }

        /// <summary>
        /// 执行顺序，从1开始
        /// </summary>
        public System.String order { get; set; }

        /// <summary>
        /// 启用状态：0,禁用；1,启用
        /// </summary>
        public System.String enable { get; set; }
    }
}