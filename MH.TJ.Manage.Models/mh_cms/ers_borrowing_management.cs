

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 财务电子报销系统借款管理
    /// </summary>
    public class ers_borrowing_management
    {
        /// <summary>
        /// 财务电子报销系统借款管理
        /// </summary>
        public ers_borrowing_management()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 借款人id
        /// </summary>
        public System.Int32? name_id { get; set; }

        /// <summary>
        /// 借款人姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 为借款还是还款（1：借款；2.还款）
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 借款或还款金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 借款或还款时间
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 还款类型（0:借款金额 1：现金还款；2.报销冲抵）
        /// </summary>
        public System.Int32? replay_type { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 报销表id
        /// </summary>
        public System.String apply_id { get; set; }
    }
}