

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 在线升级    升级所要运行SQL 语句信息
    /// </summary>
    public class mh_update_data
    {
        /// <summary>
        /// 在线升级    升级所要运行SQL 语句信息
        /// </summary>
        public mh_update_data()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String server_type { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public System.String data_type { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        public System.String columnname { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public System.String tablename { get; set; }

        /// <summary>
        /// 修改语句
        /// </summary>
        public System.String updsql { get; set; }

        /// <summary>
        /// 总版本号，主升级程序
        /// </summary>
        public System.String full_version { get; set; }

        /// <summary>
        /// 主版本号,Main_Form
        /// </summary>
        public System.String main_version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String is_enable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String reamrk { get; set; }
    }
}