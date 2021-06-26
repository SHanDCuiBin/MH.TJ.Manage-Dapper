

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 飞行检查表
    /// </summary>
    public class mms_flight_check
    {
        /// <summary>
        /// 飞行检查表
        /// </summary>
        public mms_flight_check()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public System.Int32? principal_id { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public System.String principal_name { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 检查时间
        /// </summary>
        public System.DateTime? check_time { get; set; }

        /// <summary>
        /// 创建人、监察人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}