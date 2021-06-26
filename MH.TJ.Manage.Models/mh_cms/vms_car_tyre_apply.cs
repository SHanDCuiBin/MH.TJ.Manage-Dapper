

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 钉钉轮胎申领存储表
    /// </summary>
    public class vms_car_tyre_apply
    {
        /// <summary>
        /// 钉钉轮胎申领存储表
        /// </summary>
        public vms_car_tyre_apply()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 申领类型
        /// </summary>
        public System.String tyre_type { get; set; }

        /// <summary>
        /// 轮胎数量
        /// </summary>
        public System.Int32? tyre_num { get; set; }

        /// <summary>
        /// 申领原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 钉钉申请id
        /// </summary>
        public System.String ding_talk_id { get; set; }

        /// <summary>
        /// 申请人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public System.String img { get; set; }
    }
}