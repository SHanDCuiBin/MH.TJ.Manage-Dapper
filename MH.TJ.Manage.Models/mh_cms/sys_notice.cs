

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统 通知表
    /// </summary>
    public class sys_notice
    {
        /// <summary>
        /// 系统 通知表
        /// </summary>
        public sys_notice()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public System.String title { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? creater { get; set; }
    }
}