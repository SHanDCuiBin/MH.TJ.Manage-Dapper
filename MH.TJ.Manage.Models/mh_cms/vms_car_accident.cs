

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆维修申请管理表(事故表)
    /// </summary>
    public class vms_car_accident
    {
        /// <summary>
        /// 车辆维修申请管理表(事故表)
        /// </summary>
        public vms_car_accident()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

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
        /// 维修类型
        /// </summary>
        public System.String mai_type { get; set; }

        /// <summary>
        /// 出险经过说明
        /// </summary>
        public System.String describe { get; set; }

        /// <summary>
        /// 现场图片
        /// </summary>
        public System.String scene_img { get; set; }

        /// <summary>
        /// 人车合影
        /// </summary>
        public System.String pac_prove_img { get; set; }

        /// <summary>
        /// 审批节点id
        /// </summary>
        public System.String node_id { get; set; }

        /// <summary>
        /// 流程编码
        /// </summary>
        public System.String flow_code { get; set; }

        /// <summary>
        /// 审批人id （1，2，3）
        /// </summary>
        public System.String audit_user_ids { get; set; }

        /// <summary>
        /// 审批人（张三，李四，王五）
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
        /// 审批状态
        /// </summary>
        public System.Int32 status { get; set; }

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
        /// 当前里程
        /// </summary>
        public System.Double? cuur_mileage { get; set; }

        /// <summary>
        /// 标的方损失情况（己方）
        /// </summary>
        public System.String their_loss { get; set; }

        /// <summary>
        /// 第三者损失情况（对方）
        /// </summary>
        public System.String other_loss { get; set; }

        /// <summary>
        /// 人伤情况
        /// </summary>
        public System.String people_hurt { get; set; }

        /// <summary>
        /// 费用状态（0.挂账，1未结，2已结算）
        /// </summary>
        public System.Int32? cost_status { get; set; }

        /// <summary>
        /// 是否报警（0.未报，1.已报）
        /// </summary>
        public System.Int32? is_call { get; set; }
    }
}