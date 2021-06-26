

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控信息发送微信情况
    /// </summary>
    public class qcs_push_message
    {
        /// <summary>
        /// 质控信息发送微信情况
        /// </summary>
        public qcs_push_message()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public System.String user { get; set; }

        /// <summary>
        /// 是否成功(1.成功 2.失败)
        /// </summary>
        public System.Int32? is_sucess { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 类型（1.体检 2.生化 3.血球）
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 负责人名称
        /// </summary>
        public System.String pri_user { get; set; }
    }
}