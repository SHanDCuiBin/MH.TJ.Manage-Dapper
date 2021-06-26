

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 自动升级（后台系统） 系统在线升级ip和文件地址表
    /// </summary>
    public class yk_update_info
    {
        /// <summary>
        /// 自动升级（后台系统） 系统在线升级ip和文件地址表
        /// </summary>
        public yk_update_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 操作人员部门
        /// </summary>
        public System.String Dept { get; set; }

        /// <summary>
        /// 系统的名称
        /// </summary>
        public System.String file_name { get; set; }

        /// <summary>
        /// 上传的文件名称（子名称）
        /// </summary>
        public System.String Update_FileName { get; set; }

        /// <summary>
        /// 更新下载地址
        /// </summary>
        public System.String file_path { get; set; }

        /// <summary>
        /// 1是服务   2软件   0数据库
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 上传文件描述
        /// </summary>
        public System.String description { get; set; }

        /// <summary>
        /// 更新时间/创建时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 软件版本号
        /// </summary>
        public System.String service_version { get; set; }
    }
}