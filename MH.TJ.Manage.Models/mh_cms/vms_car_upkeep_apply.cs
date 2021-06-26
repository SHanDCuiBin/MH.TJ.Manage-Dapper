

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆保养申请管理表
    /// </summary>
    public class vms_car_upkeep_apply
    {
        /// <summary>
        /// 车辆保养申请管理表
        /// </summary>
        public vms_car_upkeep_apply()
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
        /// 审批流程编号
        /// </summary>
        public System.String flow_code { get; set; }

        /// <summary>
        /// 审批节点id
        /// </summary>
        public System.String node_id { get; set; }

        /// <summary>
        /// 审核状态 1.待审批 2.通过 3.拒绝 4.已提交回执单 5.撤回
        /// </summary>
        public System.String status { get; set; }

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
        /// 上次里程数
        /// </summary>
        public System.Double? last_mileage { get; set; }

        /// <summary>
        /// 当前里程
        /// </summary>
        public System.Double? cuur_mileage { get; set; }

        /// <summary>
        /// 公里数照片
        /// </summary>
        public System.String mileage_img { get; set; }

        /// <summary>
        /// 其他照片
        /// </summary>
        public System.String othr_img { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 保养时间
        /// </summary>
        public System.DateTime? upkeep_time { get; set; }

        /// <summary>
        /// 保养内容
        /// </summary>
        public System.String upkeep_content { get; set; }

        /// <summary>
        /// 保养地点
        /// </summary>
        public System.String upkeep_site { get; set; }

        /// <summary>
        /// 保养金额
        /// </summary>
        public System.Double? upkeep_money { get; set; }

        /// <summary>
        /// 保养单图片
        /// </summary>
        public System.String upkeep_img { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        public System.String refuse_reason { get; set; }

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
        /// 钉钉审批id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 下次保养里程
        /// </summary>
        public System.Double? next_mileage { get; set; }

        /// <summary>
        /// 下次保养时间
        /// </summary>
        public System.DateTime? next_keep_time { get; set; }

        /// <summary>
        /// 钉钉通知时间(未保养)
        /// </summary>
        public System.DateTime? ding_inform { get; set; }

        /// <summary>
        /// 钉钉通知时间（未回执）
        /// </summary>
        public System.DateTime? ding_time { get; set; }

        /// <summary>
        /// 费用状态（0.挂账，1未结，2已结算）
        /// </summary>
        public System.Int32? cost_status { get; set; }

        /// <summary>
        /// 油卡里程
        /// </summary>
        public System.Double? oil_mileage { get; set; }

        /// <summary>
        /// 过期状态 0.正常，1已过期
        /// </summary>
        public System.Int32? is_under_warranty { get; set; }
    }
}