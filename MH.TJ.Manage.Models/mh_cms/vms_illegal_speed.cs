

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 违章与超速记录表
    /// </summary>
    public class vms_illegal_speed
    {
        /// <summary>
        /// 违章与超速记录表
        /// </summary>
        public vms_illegal_speed()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.Int32? car_id { get; set; }

        /// <summary>
        /// 违章人
        /// </summary>
        public System.String user { get; set; }

        /// <summary>
        /// 违章人id
        /// </summary>
        public System.Int32? user_id { get; set; }

        /// <summary>
        /// 违章时间/超速时间
        /// </summary>
        public System.DateTime? time { get; set; }

        /// <summary>
        /// 违章地址
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 违章行为
        /// </summary>
        public System.String behavior { get; set; }

        /// <summary>
        /// 扣分
        /// </summary>
        public System.Int32? score { get; set; }

        /// <summary>
        /// 罚款
        /// </summary>
        public System.Decimal? pay_money { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        public System.String deal_state { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 状态（1.违章 2.超速）
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 超速次数
        /// </summary>
        public System.Int32? count { get; set; }

        /// <summary>
        /// 超速速度
        /// </summary>
        public System.Double? speed { get; set; }
    }
}