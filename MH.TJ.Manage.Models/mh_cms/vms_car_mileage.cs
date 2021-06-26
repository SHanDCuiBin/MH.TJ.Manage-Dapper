

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆里程数修改记录
    /// </summary>
    public class vms_car_mileage
    {
        /// <summary>
        /// 车辆里程数修改记录
        /// </summary>
        public vms_car_mileage()
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
        /// 公里数
        /// </summary>
        public System.Int32? mileage { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        public System.Int32? type { get; set; }

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
    }
}