

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 途强用户信息
    /// </summary>
    public class tq_user_info
    {
        /// <summary>
        /// 途强用户信息
        /// </summary>
        public tq_user_info()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 登录帐号
        /// </summary>
        public System.String account { get; set; }

        /// <summary>
        /// 	显示名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 帐号类型 3：终端用户 8：一级代理商 9：普通用户 10：普通代理商 11：销售
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 	是否启用(1:启用,0:不启用)
        /// </summary>
        public System.SByte? display_flag { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        public System.String company_name { get; set; }
    }
}