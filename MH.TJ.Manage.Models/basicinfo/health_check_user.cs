

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 居民参检用户表-包含登录信息
    /// </summary>
    public class health_check_user
    {
        /// <summary>
        /// 居民参检用户表-包含登录信息
        /// </summary>
        public health_check_user()
        {
        }

        /// <summary>
        /// 主键 用户类型_身份证_姓名_出生日期(yyyyMMdd)
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 沐华编号
        /// </summary>
        public System.String mh_card { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public System.String real_name { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 用户头像  
        /// </summary>
        public System.String user_icon { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 用户密码加密密钥（“mh*#$_6715yl”）
        /// </summary>
        public System.String password { get; set; }

        /// <summary>
        /// 最近获取的验证码
        /// </summary>
        public System.String valite_code { get; set; }

        /// <summary>
        /// 验证码获取次数
        /// </summary>
        public System.Int32? valite_count { get; set; }

        /// <summary>
        /// 验证码最近获取的时间
        /// </summary>
        public System.DateTime? valite_time { get; set; }

        /// <summary>
        /// 最近登录时间
        /// </summary>
        public System.DateTime? login_time { get; set; }

        /// <summary>
        /// 是否已经注册 0/null 未注册  1 已注册
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 用户账号激活时间
        /// </summary>
        public System.DateTime? enable_time { get; set; }

        /// <summary>
        /// 用户创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}