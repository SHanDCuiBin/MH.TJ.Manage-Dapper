

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 问题解决方案表
    /// </summary>
    public class cms_solution
    {
        /// <summary>
        /// 问题解决方案表
        /// </summary>
        public cms_solution()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 问题类型id
        /// </summary>
        public System.String typeid { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public System.String title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public System.String contents { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? createuserid { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String createuser { get; set; }

        /// <summary>
        /// 是否解决 0未解决 1.已解决 2.已回答
        /// </summary>
        public System.Int32? is_solved { get; set; }
    }
}