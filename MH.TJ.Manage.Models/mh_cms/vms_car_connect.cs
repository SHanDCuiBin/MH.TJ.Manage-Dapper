

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 钉钉车辆交接存放信息 
    /// </summary>
    public class vms_car_connect
    {
        /// <summary>
        /// 钉钉车辆交接存放信息 
        /// </summary>
        public vms_car_connect()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String reception_user { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 车辆里程
        /// </summary>
        public System.Double? curr_mileage { get; set; }

        /// <summary>
        /// 交接日期
        /// </summary>
        public System.DateTime? apply_time { get; set; }

        /// <summary>
        /// 卡内余额
        /// </summary>
        public System.Double? kn_money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 钉钉id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.Int32? reception_user_id { get; set; }

        /// <summary>
        /// 是否是车辆交接（1.车辆交接，2.用车）
        /// </summary>
        public System.Int32? is_reception { get; set; }

        /// <summary>
        /// 用车事由
        /// </summary>
        public System.String reasons { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }
    }
}