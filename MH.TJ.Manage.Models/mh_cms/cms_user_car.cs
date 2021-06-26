

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 人员车辆 变更关系表
    /// </summary>
    public class cms_user_car
    {
        /// <summary>
        /// 人员车辆 变更关系表
        /// </summary>
        public cms_user_car()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 现负责人ID
        /// </summary>
        public System.String USER_ID { get; set; }

        /// <summary>
        /// 原负责人id
        /// </summary>
        public System.String originUserId { get; set; }

        /// <summary>
        /// 汽车ID号
        /// </summary>
        public System.String CAR_ID { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public System.DateTime? START_TIME { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public System.DateTime? END_TIME { get; set; }

        /// <summary>
        /// 是否结束标记
        /// </summary>
        public System.Int32? IS_FINISHED_FLAG { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CREATE_TIME { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public System.String CREATE_USER_ID { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? UPDATE_TIME { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        public System.String UPDATE_USER_ID { get; set; }
    }
}