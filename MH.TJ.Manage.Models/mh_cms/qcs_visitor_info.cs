

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控推送系统意见反馈登陆短信日志
    /// </summary>
    public class qcs_visitor_info
    {
        /// <summary>
        /// 质控推送系统意见反馈登陆短信日志
        /// </summary>
        public qcs_visitor_info()
        {
        }

        /// <summary>
        /// 手机号
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public System.String auth_code { get; set; }

        /// <summary>
        /// 验证码时间
        /// </summary>
        public System.DateTime? auth_code_time { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public System.Int32 login_num { get; set; }

        /// <summary>
        /// 短信失败时间及原因
        /// </summary>
        public System.String msg { get; set; }
    }
}