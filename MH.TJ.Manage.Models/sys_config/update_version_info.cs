

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 系统升级表 （院内、数据处理使用） 测试
    /// </summary>
    public class update_version_info
    {
        /// <summary>
        /// 系统升级表 （院内、数据处理使用） 测试
        /// </summary>
        public update_version_info()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 程序名称(中文)
        /// </summary>
        public System.String program_name { get; set; }

        /// <summary>
        /// 除webapi和vue页面外使用程序名（去掉.exe）
        /// </summary>
        public System.String item { get; set; }

        /// <summary>
        /// 版本号 x.x.x.x 
        /// </summary>
        public System.String version { get; set; }

        /// <summary>
        /// 升级信息
        /// </summary>
        public System.String update_info { get; set; }

        /// <summary>
        /// webservice安装包用的下载地址
        /// </summary>
        public System.String download_url { get; set; }

        /// <summary>
        /// 是否强制更新 1为强制更新 0为不强制更新
        /// </summary>
        public System.Int32? is_force { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 院内强制升级的机构的机构号   多机构使用,分开
        /// </summary>
        public System.String force_org { get; set; }
    }
}