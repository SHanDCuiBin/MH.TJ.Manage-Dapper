

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 短信验证码
    /// </summary>
    public class message_code
    {
        /// <summary>
        /// 短信验证码
        /// </summary>
        public message_code()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public System.String user_phone { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public System.String verification_code { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_datetime { get; set; }

        /// <summary>
        /// 发送短信返回的错误信息
        /// </summary>
        public System.String error_mess { get; set; }

        /// <summary>
        /// 用户ip
        /// </summary>
        public System.String user_ip { get; set; }

        /// <summary>
        /// 短信类型 1为幼儿园验证码 2为老年人查体前短信 3为老年人报告领取短信 4为下载短信名单验证码
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public System.String message_content { get; set; }

        /// <summary>
        /// 短信发送人账号
        /// </summary>
        public System.String sms_sender_id { get; set; }

        /// <summary>
        /// 短信发送人姓名
        /// </summary>
        public System.String sms_sender_name { get; set; }

        /// <summary>
        /// 发送年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 查体信息短信发送表id
        /// </summary>
        public System.String ct_info_id { get; set; }
    }
}