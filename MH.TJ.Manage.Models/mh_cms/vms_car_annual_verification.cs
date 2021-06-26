

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆年审表
    /// </summary>
    public class vms_car_annual_verification
    {
        /// <summary>
        /// 车辆年审表
        /// </summary>
        public vms_car_annual_verification()
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
        /// 实际审车人id
        /// </summary>
        public System.Int32? real_vi_user_id { get; set; }

        /// <summary>
        /// 实际审车人
        /// </summary>
        public System.String real_vi_user { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        public System.Int32? pri_user_id { get; set; }

        /// <summary>
        /// 行驶证照片
        /// </summary>
        public System.String plate_img { get; set; }

        /// <summary>
        /// 车辆年审日期
        /// </summary>
        public System.DateTime? vi_date { get; set; }

        /// <summary>
        /// 下次年审日期
        /// </summary>
        public System.DateTime? next_date { get; set; }

        /// <summary>
        /// 年审图片
        /// </summary>
        public System.String vi_url { get; set; }

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

        /// <summary>
        /// 是否删除 0否 1.是
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 是否过期0正常1已过期
        /// </summary>
        public System.Int32 is_under_warranty { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String notes { get; set; }

        /// <summary>
        /// 年审费用
        /// </summary>
        public System.Double? vi_money { get; set; }

        /// <summary>
        /// 钉钉上次提醒时间
        /// </summary>
        public System.DateTime? ding_time { get; set; }
    }
}