

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 体检配置文件信息表
    /// </summary>
    public class ini_tableinfo
    {
        /// <summary>
        /// 体检配置文件信息表
        /// </summary>
        public ini_tableinfo()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 配置文件id(外键)
        /// </summary>
        public System.String ini_id { get; set; }

        /// <summary>
        /// 配置文件相对路径（主程序）
        /// </summary>
        public System.String relativepath { get; set; }

        /// <summary>
        /// 配置文件名称（包文件括扩展名）
        /// </summary>
        public System.String filename { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String module_name { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        public System.String key_name { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        public System.String key_value { get; set; }

        /// <summary>
        /// 详细描述
        /// </summary>
        public System.String describe { get; set; }
    }
}