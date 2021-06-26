

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控推送系统意见反馈表
    /// </summary>
    public class qcs_problem_feedback
    {
        /// <summary>
        /// 质控推送系统意见反馈表
        /// </summary>
        public qcs_problem_feedback()
        {
        }

        /// <summary>
        /// 主键 UUID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 反馈模板
        /// </summary>
        public System.String module { get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
        public System.String describe { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public System.String img { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public System.String qq { get; set; }

        /// <summary>
        /// 微信号
        /// </summary>
        public System.String wechat { get; set; }

        /// <summary>
        /// 内部评价
        /// </summary>
        public System.String evaluate { get; set; }

        /// <summary>
        /// 问题状态0.待处理1.采纳2.不采纳3.待讨论
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 问题来源
        /// </summary>
        public System.String source { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改人姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}