

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆油卡信息表
    /// </summary>
    public class vms_car_oil_card
    {
        /// <summary>
        /// 车辆油卡信息表
        /// </summary>
        public vms_car_oil_card()
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
        /// 1.石油2石化
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public System.String card_no { get; set; }

        /// <summary>
        /// 客户类型 1.公用2.私用3.客户4.医疗车、5.内部车辆、6.外部车辆
        /// </summary>
        public System.Int32? user_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 0.启用1.禁用
        /// </summary>
        public System.Int32 enable { get; set; }

        /// <summary>
        /// 领卡时间
        /// </summary>
        public System.DateTime? get_time { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 领卡人
        /// </summary>
        public System.String card_holder { get; set; }

        /// <summary>
        /// 领卡人id
        /// </summary>
        public System.Int32? card_holder_id { get; set; }

        /// <summary>
        /// 是否删除 0否 1.是
        /// </summary>
        public System.Int32 is_delete { get; set; }

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
    }
}