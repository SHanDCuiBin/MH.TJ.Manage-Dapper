

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 模块升级包
    /// </summary>
    public class upgradepackage
    {
        /// <summary>
        /// 模块升级包
        /// </summary>
        public upgradepackage()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        public System.String mainid { get; set; }

        /// <summary>
        /// 模块升级描述
        /// </summary>
        public System.String describe { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 是否可用 0不可用  1可用
        /// </summary>
        public System.String enable { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public System.String downloadurl { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String createuserid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String version { get; set; }

        /// <summary>
        /// 更新包地址
        /// </summary>
        public System.String update_url { get; set; }

        /// <summary>
        /// 升级包版本 0是测试版 1是试用版 2是正式版
        /// </summary>
        public System.String type { get; set; }
    }
}