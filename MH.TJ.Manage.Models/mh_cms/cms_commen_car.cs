

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆-负责人信息表
    /// </summary>
    public class cms_commen_car
    {
        /// <summary>
        /// 车辆-负责人信息表
        /// </summary>
        public cms_commen_car()
        {
        }

        /// <summary>
        /// 主键 
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String PLATE_NO { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public System.String VIN { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        public System.String ENGINE_NO { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        public System.String CAR_XH { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public System.DateTime? BUY_TIME { get; set; }

        /// <summary>
        /// 负责人Id
        /// </summary>
        public System.String PRICIPAL_ID { get; set; }

        /// <summary>
        /// 保险名称
        /// </summary>
        public System.String INSURANCE_NAME { get; set; }

        /// <summary>
        /// 保险到期时间
        /// </summary>
        public System.DateTime? INSURANCE_TIME { get; set; }

        /// <summary>
        /// 最近保养时间
        /// </summary>
        public System.DateTime? MAINTAIN_TIME { get; set; }

        /// <summary>
        /// 年检日期
        /// </summary>
        public System.DateTime? NIAN_JIAN_TIME { get; set; }

        /// <summary>
        /// 保养公里数
        /// </summary>
        public System.Int64? MAINTAIN_MILEAGE { get; set; }

        /// <summary>
        /// 车辆状态0.空闲 1.使用 2.维修保养中 3.报废 4.出让5.删除
        /// </summary>
        public System.Int32? STATE { get; set; }

        /// <summary>
        /// 创建日期
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

        /// <summary>
        /// 途强车辆 IMEI
        /// </summary>
        public System.String IMEI { get; set; }
    }
}