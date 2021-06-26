

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 查体短信推送人员信息记录表
    /// </summary>
    public class ct_info_sms_send
    {
        /// <summary>
        /// 查体短信推送人员信息记录表
        /// </summary>
        public ct_info_sms_send()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 查体类型 1是老年人 2是幼儿园 3是中小学生
        /// </summary>
        public System.Int32? check_type { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 性别 1男 2女
        /// </summary>
        public System.String sex { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public System.String telephone { get; set; }

        /// <summary>
        /// 地址 街道/居委会
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public System.String linkman { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public System.String linkman_telephone { get; set; }

        /// <summary>
        /// 居住地址详情   详细地址
        /// </summary>
        public System.String address_detail { get; set; }

        /// <summary>
        /// 上次短信发送时间
        /// </summary>
        public System.DateTime? last_send_time { get; set; }

        /// <summary>
        /// 上次查体前通知短信发送时间
        /// </summary>
        public System.DateTime? last_ctq_send_time { get; set; }

        /// <summary>
        /// 查体前通知短信发送次数
        /// </summary>
        public System.Int32? ctq_send_count { get; set; }

        /// <summary>
        /// 上次查体前通知短信发送是否成功 1为成功  0为失败
        /// </summary>
        public System.Int32? last_ctq_success { get; set; }

        /// <summary>
        /// 上次报告领取短信发送时间
        /// </summary>
        public System.DateTime? last_bglq_send_time { get; set; }

        /// <summary>
        /// 告领取短信发送次数
        /// </summary>
        public System.Int32? bglq_send_count { get; set; }

        /// <summary>
        /// 上次报告领取短信发送是否成功 0为失败
        /// </summary>
        public System.Int32? last_bglq_success { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人账号
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 更新人账号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 更新人姓名
        /// </summary>
        public System.String update_user_name { get; set; }
    }
}