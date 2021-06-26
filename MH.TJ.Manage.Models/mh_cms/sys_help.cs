

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统帮助表
    /// </summary>
    public class sys_help
    {
        /// <summary>
        /// 系统帮助表
        /// </summary>
        public sys_help()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 系统name
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 系统url
        /// </summary>
        public System.String url { get; set; }

        /// <summary>
        /// 富文本内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 状态 1启用 2禁用
        /// </summary>
        public System.String state { get; set; }
    }
}