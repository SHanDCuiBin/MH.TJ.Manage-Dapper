

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 审批流程表（流程线路）
    /// </summary>
    public class vms_car_audit_flow
    {
        /// <summary>
        /// 审批流程表（流程线路）
        /// </summary>
        public vms_car_audit_flow()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 流程编号
        /// </summary>
        public System.String flow_code { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.Int32? aplly_user_id { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        public System.Int32? audit_user_id { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public System.String audit_user { get; set; }

        /// <summary>
        /// 上级节点（-1表示开始）
        /// </summary>
        public System.String prev_node { get; set; }

        /// <summary>
        /// 下级节点（-1表示结束）
        /// </summary>
        public System.String next_node { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }
    }
}