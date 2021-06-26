

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 版本表
    /// </summary>
    public class versiondb
    {
        /// <summary>
        /// 版本表
        /// </summary>
        public versiondb()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public System.String version_num { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dowload_url { get; set; }

        /// <summary>
        /// 类型 1.安卓 2.苹果
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 状态 1.启用 2.废弃
        /// </summary>
        public System.String state { get; set; }
    }
}