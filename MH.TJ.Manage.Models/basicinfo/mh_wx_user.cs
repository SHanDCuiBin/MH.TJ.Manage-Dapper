

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 微信端登录用户表
    /// </summary>
    public class mh_wx_user
    {
        /// <summary>
        /// 微信端登录用户表
        /// </summary>
        public mh_wx_user()
        {
        }

        /// <summary>
        /// 主键 用户类型_身份证_姓名_出生日期(yyyyMMdd)
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 01 儿童  02 老年人 03 孕产妇 04 慢病用户
        /// </summary>
        public System.String user_type { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public System.String real_name { get; set; }

        /// <summary>
        /// 用户微信用户身份证
        /// </summary>
        public System.String sfz { get; set; }

        /// <summary>
        /// 性别   男  女
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// 用户出生日期
        /// </summary>
        public System.DateTime? csrq { get; set; }

        /// <summary>
        /// 用户电话
        /// </summary>
        public System.String lxdh { get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        public System.String address { get; set; }

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

        /// <summary>
        /// 沐华编号
        /// </summary>
        public System.String mh_card { get; set; }
    }
}