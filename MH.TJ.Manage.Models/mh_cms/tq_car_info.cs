

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆基本信息与最新定位信息
    /// </summary>
    public class tq_car_info
    {
        /// <summary>
        /// 车辆基本信息与最新定位信息
        /// </summary>
        public tq_car_info()
        {
        }

        /// <summary>
        /// 设备IMEI
        /// </summary>
        public System.String imei { get; set; }

        /// <summary>
        /// 途强账号名
        /// </summary>
        public System.Int32? tq_user_id { get; set; }

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

        /// <summary>
        /// 到期时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.String expiration { get; set; }

        /// <summary>
        /// 激活时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        public System.DateTime? activation_time { get; set; }

        /// <summary>
        /// 车辆名称
        /// </summary>
        public System.String vehicle_name { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String vehicle_number { get; set; }

        /// <summary>
        /// 	车辆品牌
        /// </summary>
        public System.String vehicle_models { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public System.String car_frame { get; set; }

        /// <summary>
        /// 司机名称
        /// </summary>
        public System.String driver_name { get; set; }

        /// <summary>
        /// 	司机电话
        /// </summary>
        public System.String driver_phone { get; set; }

        /// <summary>
        /// 是否启用（0：不启用；1：启用）
        /// </summary>
        public System.SByte? enabled_flag { get; set; }

        /// <summary>
        /// 电机发动机号
        /// </summary>
        public System.String engine_number { get; set; }
    }
}