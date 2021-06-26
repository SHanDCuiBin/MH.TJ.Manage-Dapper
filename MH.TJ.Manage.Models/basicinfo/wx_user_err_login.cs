

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class wx_user_err_login
    {
        /// <summary>
        /// 
        /// </summary>
        public wx_user_err_login()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 微信用户id
        /// </summary>
        public System.String wx_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_tel { get; set; }

        /// <summary>
        /// 登录错误次数。默认0 最大值5
        /// </summary>
        public System.Int32? err_login_count { get; set; }

        /// <summary>
        /// 最后一次登录错误时间
        /// </summary>
        public System.DateTime? last_login_err_time { get; set; }

        /// <summary>
        /// 是否锁定。0 未锁顶；1 锁定
        /// </summary>
        public System.Int32 is_locked { get; set; }
    }
}