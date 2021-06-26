

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 报销表
    /// </summary>
    public class sys_expense
    {
        /// <summary>
        /// 报销表
        /// </summary>
        public sys_expense()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 报销金额
        /// </summary>
        public System.Decimal? money { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public System.String desc { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? createtime { get; set; }

        /// <summary>
        /// 状态: 1.待提交  2:待审核   3.审核通过 4:驳回
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public System.Int32? userid { get; set; }

        /// <summary>
        /// 流程定义id
        /// </summary>
        public System.String processId { get; set; }
    }
}