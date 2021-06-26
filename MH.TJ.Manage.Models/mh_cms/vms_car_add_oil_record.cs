

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆油卡-加油记录表
    /// </summary>
    public class vms_car_add_oil_record
    {
        /// <summary>
        /// 车辆油卡-加油记录表
        /// </summary>
        public vms_car_add_oil_record()
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
        /// 油卡类型(石油,石化)
        /// </summary>
        public System.String card_type { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public System.String card_no { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public System.Double? unit_price { get; set; }

        /// <summary>
        /// 加油量/升
        /// </summary>
        public System.Double? quantity { get; set; }

        /// <summary>
        /// 加油金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 卡内余额
        /// </summary>
        public System.Double? kn_money { get; set; }

        /// <summary>
        /// 加油日期
        /// </summary>
        public System.DateTime? add_date { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        public System.Double? discounts { get; set; }

        /// <summary>
        /// 当前里程数
        /// </summary>
        public System.Double? curr_mileage { get; set; }

        /// <summary>
        /// 加油小票
        /// </summary>
        public System.String receipt_img { get; set; }

        /// <summary>
        /// 公里数照片
        /// </summary>
        public System.String mileage_img { get; set; }

        /// <summary>
        /// 领卡人(加油人)
        /// </summary>
        public System.String card_holder { get; set; }

        /// <summary>
        /// 油卡充值申请id（用于查询油卡充值信息）
        /// </summary>
        public System.Int32? apply_id { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        ///  创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 是否撤销，0正常1撤销
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 油耗
        /// </summary>
        public System.Double? oil_wear { get; set; }
    }
}