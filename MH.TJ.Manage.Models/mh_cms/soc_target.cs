

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 目标表(分级别)
    /// </summary>
    public class soc_target
    {
        /// <summary>
        /// 目标表(分级别)
        /// </summary>
        public soc_target()
        {
        }

        /// <summary>
        /// ID 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public System.Int64? p_id { get; set; }

        /// <summary>
        /// 父级目标
        /// </summary>
        public System.String p_name { get; set; }

        /// <summary>
        /// 目标等级:
        ///1.战略目标
        ///2.公司年度目标
        ///3.部门年度目标
        ///4.团队年度目标
        ///5.团队月度目标
        ///6.个人目标
        /// </summary>
        public System.SByte? level { get; set; }

        /// <summary>
        /// 年度/月度
        /// </summary>
        public System.String time { get; set; }

        /// <summary>
        /// 目标
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 类型 
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 目标内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 完成标准
        /// </summary>
        public System.String standard { get; set; }

        /// <summary>
        /// 完成结果形式
        /// </summary>
        public System.String result_type { get; set; }

        /// <summary>
        /// 预计完成时间
        /// </summary>
        public System.DateTime? et_time { get; set; }

        /// <summary>
        /// 挑战完成日期
        /// </summary>
        public System.DateTime? challenge_time { get; set; }

        /// <summary>
        /// 是否为挑战目标
        /// </summary>
        public System.SByte? is_challenge { get; set; }

        /// <summary>
        /// 接收人（默认创建人）
        /// </summary>
        public System.Int64? receiver_id { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 完成情况: 0未开始，1已达成，2未达成，3进行中，4中止，5已取消
        /// </summary>
        public System.SByte state { get; set; }

        /// <summary>
        /// 确认完成时间
        /// </summary>
        public System.DateTime? achieve_time { get; set; }

        /// <summary>
        /// 负责人ID
        /// </summary>
        public System.Int64? principal_user_id { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public System.String principal_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public System.Int64 create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }
    }
}