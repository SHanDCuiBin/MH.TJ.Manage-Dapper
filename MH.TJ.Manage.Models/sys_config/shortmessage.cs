

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 短信验证
    /// </summary>
    public class shortmessage
    {
        /// <summary>
        /// 短信验证
        /// </summary>
        public shortmessage()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 模块类型
        /// </summary>
        public System.String modeltype { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public System.String codenum { get; set; }

        /// <summary>
        /// 创建人ID，申请人
        /// </summary>
        public System.String createrid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String simplecontent { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// 是否可用 0不可用 1可以用
        /// </summary>
        public System.Int32? enable { get; set; }
    }
}