

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 油卡充值申请管理表
    /// </summary>
    public class vms_car_oli_apply
    {
        /// <summary>
        /// 油卡充值申请管理表
        /// </summary>
        public vms_car_oli_apply()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 流程编号
        /// </summary>
        public System.String flow_code { get; set; }

        /// <summary>
        /// 审批节点id
        /// </summary>
        public System.String node_id { get; set; }

        /// <summary>
        /// 审核状态
        ///1.待审核 2.审核完成,待充值 3.驳回 4.充值成功
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 审批人id
        /// </summary>
        public System.String audit_user_ids { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        public System.String audit_users { get; set; }

        /// <summary>
        /// 抄送人id
        /// </summary>
        public System.String copy_user_ids { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public System.String copy_users { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        public System.Int32? apply_user_id { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String apply_user { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        public System.DateTime? apply_time { get; set; }

        /// <summary>
        /// 油卡类型(石油,石化)
        /// </summary>
        public System.Int32? card_type { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public System.String card_no { get; set; }

        /// <summary>
        /// 申请金额
        /// </summary>
        public System.Double? apply_money { get; set; }

        /// <summary>
        /// 实际充值金额
        /// </summary>
        public System.Double? real_money { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public System.String refuse_reason { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 拒绝人
        /// </summary>
        public System.String refuse_user { get; set; }

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

        /// <summary>
        /// 钉钉id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 充值日期
        /// </summary>
        public System.DateTime? recharge_time { get; set; }

        /// <summary>
        /// 车辆类型（1.医疗车、2.内部车辆、3.外部车辆）
        /// </summary>
        public System.Int32? user_type { get; set; }

        /// <summary>
        /// 充值人
        /// </summary>
        public System.String recharge_name { get; set; }
    }
}