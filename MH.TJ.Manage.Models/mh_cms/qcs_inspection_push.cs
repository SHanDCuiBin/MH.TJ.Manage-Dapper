

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 检验质控客户推送信息
    /// </summary>
    public class qcs_inspection_push
    {
        /// <summary>
        /// 检验质控客户推送信息
        /// </summary>
        public qcs_inspection_push()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 检验医师
        /// </summary>
        public System.String check_physician { get; set; }

        /// <summary>
        /// 生化质控模板id
        /// </summary>
        public System.String quality_id { get; set; }

        /// <summary>
        /// 监督医师
        /// </summary>
        public System.String physician_name { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public System.String head_user { get; set; }

        /// <summary>
        /// 是否同意（1.同意2.拒绝）
        /// </summary>
        public System.Int32? is_agree { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public System.String refused_reason { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 类型（1/null.检验质控 2.血球质控）
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 签名照片
        /// </summary>
        public System.String signature { get; set; }

        /// <summary>
        /// 负责人账号
        /// </summary>
        public System.String head_user_id { get; set; }

        /// <summary>
        /// 时间戳字段（验证数据）
        /// </summary>
        public System.String time_stamp { get; set; }
    }
}