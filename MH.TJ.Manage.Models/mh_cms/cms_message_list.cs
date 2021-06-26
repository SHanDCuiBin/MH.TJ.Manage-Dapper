

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 申请 审批 抄送 等等 信息列表
    /// </summary>
    public class cms_message_list
    {
        /// <summary>
        /// 申请 审批 抄送 等等 信息列表
        /// </summary>
        public cms_message_list()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public System.String message { get; set; }

        /// <summary>
        /// 模块名称id
        /// </summary>
        public System.Int32? module_id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String module_name { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public System.String _operator { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        public System.Int32? operator_id { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String receiver { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.Int32? receiver_id { get; set; }

        /// <summary>
        /// 对应模块的记录id
        /// </summary>
        public System.String linked_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 1.申请 2.审批 3.抄送
        /// </summary>
        public System.SByte? type { get; set; }

        /// <summary>
        /// 0待审批 1.通过 2未通过3.不需要审批
        /// </summary>
        public System.SByte? state { get; set; }

        /// <summary>
        /// 审核人数
        /// </summary>
        public System.Int32? audit_count { get; set; }

        /// <summary>
        /// 当前审核人编号 审核人表
        /// </summary>
        public System.Int32? cur_auditor_num { get; set; }

        /// <summary>
        /// 抄送人数
        /// </summary>
        public System.Int32? copy_count { get; set; }
    }
}