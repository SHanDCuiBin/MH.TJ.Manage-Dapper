

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆轨迹
    /// </summary>
    public class tq_car_track
    {
        /// <summary>
        /// 车辆轨迹
        /// </summary>
        public tq_car_track()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 设备IMEI
        /// </summary>
        public System.String imei { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public System.String device_name { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        public System.String mc_type { get; set; }

        /// <summary>
        /// 设备状态 0,离线; 1,在线
        /// </summary>
        public System.String status { get; set; }

        /// <summary>
        /// 纬度 (如果设备过期，值为0)
        /// </summary>
        public System.Double? lat { get; set; }

        /// <summary>
        /// 	经度 (如果设备过期，值为0)
        /// </summary>
        public System.Double? lng { get; set; }

        /// <summary>
        /// 上次请求时间
        /// </summary>
        public System.DateTime? request_time { get; set; }

        /// <summary>
        /// GPS定位时间
        /// </summary>
        public System.DateTime? gps_time { get; set; }

        /// <summary>
        /// 心跳时间
        /// </summary>
        public System.DateTime? hb_time { get; set; }

        /// <summary>
        /// 速度 (单位:km/h)
        /// </summary>
        public System.Double? speed { get; set; }

        /// <summary>
        /// Acc状态 0:关闭 1:打开
        /// </summary>
        public System.String acc_status { get; set; }

        /// <summary>
        /// 设备电量（0-100），部分设备型号不支持
        /// </summary>
        public System.String elect_quantity { get; set; }

        /// <summary>
        /// 外电电压（0-100），部分设备支持
        /// </summary>
        public System.String power_value { get; set; }
    }
}