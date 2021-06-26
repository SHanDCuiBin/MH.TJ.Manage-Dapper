

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 自动升级（后台系统） 系统在线升级的说明记录（更新内容说明）
    /// </summary>
    public class yk_update_record
    {
        /// <summary>
        /// 自动升级（后台系统） 系统在线升级的说明记录（更新内容说明）
        /// </summary>
        public yk_update_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 使用部门：DP（数据处理）
        /// </summary>
        public System.String Dept { get; set; }

        /// <summary>
        /// 软件版本号
        /// </summary>
        public System.String service_version { get; set; }

        /// <summary>
        /// 更新文件名
        /// </summary>
        public System.String Update_FileName { get; set; }

        /// <summary>
        /// 版本描述（更新内容）
        /// </summary>
        public System.String description { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? createTime { get; set; }
    }
}