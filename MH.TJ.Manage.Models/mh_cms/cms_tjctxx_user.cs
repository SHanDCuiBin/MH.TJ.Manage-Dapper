

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 区域负责查体人数信息表
    /// </summary>
    public class cms_tjctxx_user
    {
        /// <summary>
        /// 区域负责查体人数信息表
        /// </summary>
        public cms_tjctxx_user()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 查体信息表ID号
        /// </summary>
        public System.String CTXX_ID { get; set; }

        /// <summary>
        /// 用户表的用户ID号
        /// </summary>
        public System.String USER_ID { get; set; }

        /// <summary>
        /// 查体人人数(跟车工程师人数)
        /// </summary>
        public System.Int32? CTR_COUNT { get; set; }
    }
}