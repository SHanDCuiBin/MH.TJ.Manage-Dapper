

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆维修-回执单管理表(维修回执单)
    /// </summary>
    public class vms_car_repair
    {
        /// <summary>
        /// 车辆维修-回执单管理表(维修回执单)
        /// </summary>
        public vms_car_repair()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 维修申请单id
        /// </summary>
        public System.String accident_id { get; set; }

        /// <summary>
        /// 维修时间
        /// </summary>
        public System.DateTime? repair_date { get; set; }

        /// <summary>
        /// 出险地点
        /// </summary>
        public System.String danger_add { get; set; }

        /// <summary>
        /// 事故责任
        /// </summary>
        public System.String accident_liability { get; set; }

        /// <summary>
        /// 维修内容
        /// </summary>
        public System.String repair_part { get; set; }

        /// <summary>
        /// 维修地点
        /// </summary>
        public System.String repair_add { get; set; }

        /// <summary>
        /// 维修金额
        /// </summary>
        public System.Double? repair_money { get; set; }

        /// <summary>
        /// 维修单
        /// </summary>
        public System.String repair_bill { get; set; }

        /// <summary>
        /// 122证明
        /// </summary>
        public System.String prove122 { get; set; }

        /// <summary>
        /// 现场照
        /// </summary>
        public System.String live_prove { get; set; }

        /// <summary>
        /// 人车合影
        /// </summary>
        public System.String pac_prove { get; set; }

        /// <summary>
        /// 其他相关资料
        /// </summary>
        public System.String other_prove { get; set; }

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
        /// 人伤情况必填
        /// </summary>
        public System.String people_hurt { get; set; }

        /// <summary>
        /// 标的方保险金额
        /// </summary>
        public System.Decimal? their_money { get; set; }

        /// <summary>
        /// 第三方保险金额
        /// </summary>
        public System.Decimal? other_money { get; set; }
    }
}