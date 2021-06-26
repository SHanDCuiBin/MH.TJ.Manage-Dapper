

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 审批流程记录表
    /// </summary>
    public class vms_car_audit_record
    {
        /// <summary>
        /// 审批流程记录表
        /// </summary>
        public vms_car_audit_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public System.Int32? type { get; set; }

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
        /// 操作时间
        /// </summary>
        public System.DateTime? audit_time { get; set; }

        /// <summary>
        /// 通过/不通过 （1/2）
        /// </summary>
        public System.Int32? is_agree { get; set; }

        /// <summary>
        ///  不通过原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 业务表id
        /// </summary>
        public System.String linked_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

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