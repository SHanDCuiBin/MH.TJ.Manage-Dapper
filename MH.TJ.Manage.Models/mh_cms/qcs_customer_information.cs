

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控推送系统客户信息表
    /// </summary>
    public class qcs_customer_information
    {
        /// <summary>
        /// 质控推送系统客户信息表
        /// </summary>
        public qcs_customer_information()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 电话号码
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
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public System.String position { get; set; }

        /// <summary>
        /// 1.启用2.禁用
        /// </summary>
        public System.Boolean enable { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public System.DateTime? start_time { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.DateTime? end_time { get; set; }

        /// <summary>
        /// 短信发送功能1.启用2.禁用
        /// </summary>
        public System.Boolean msg_enable { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 短信失败时间及原因
        /// </summary>
        public System.String msg { get; set; }

        /// <summary>
        /// 无数据推送 1是2否
        /// </summary>
        public System.Int32 no_data_push { get; set; }

        /// <summary>
        /// 推送时间 0每天;w1周一;m1每月一号
        /// </summary>
        public System.String push_time { get; set; }

        /// <summary>
        /// 公众号推送功能1.启用 2.禁用
        /// </summary>
        public System.Boolean? wx_enable { get; set; }

        /// <summary>
        /// 推送类型（1.检验业务指控 2.体检业务指控 3.两者都有）
        /// </summary>
        public System.Boolean? push_status { get; set; }

        /// <summary>
        /// 微信绑定用户号
        /// </summary>
        public System.String open_id { get; set; }

        /// <summary>
        /// 检验医师
        /// </summary>
        public System.String check_physician { get; set; }
    }
}