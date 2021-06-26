

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 检验对接身份认证表
    /// </summary>
    public class identityauth
    {
        /// <summary>
        /// 检验对接身份认证表
        /// </summary>
        public identityauth()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 合作单位code
        /// </summary>
        public System.String company_code { get; set; }

        /// <summary>
        /// 合作单位名称
        /// </summary>
        public System.String company_name { get; set; }

        /// <summary>
        /// 身份认证码
        /// </summary>
        public System.String identityauth_code { get; set; }

        /// <summary>
        /// 盐值
        /// </summary>
        public System.String salt_key { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public System.DateTime? expirydatetime { get; set; }

        /// <summary>
        /// 是否冻结，0未冻结  1已冻结
        /// </summary>
        public System.String is_frozen { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_userid { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 上一次更新人
        /// </summary>
        public System.String update_userid { get; set; }

        /// <summary>
        /// 上一次更新时间
        /// </summary>
        public System.DateTime? updatedate { get; set; }
    }
}