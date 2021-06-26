

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆基本信息表
    /// </summary>
    public class vms_car_info
    {
        /// <summary>
        /// 车辆基本信息表
        /// </summary>
        public vms_car_info()
        {
        }

        /// <summary>
        /// id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        public System.String engine_no { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public System.String vin { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        public System.String car_brand { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        public System.String car_version { get; set; }

        /// <summary>
        /// 车辆类型1.小型专用客车(两年一审)2.轻型非载货专项作业车(1年1审)3.家庭用车(1年1审)
        /// </summary>
        public System.Int32? car_type { get; set; }

        /// <summary>
        /// 购车公司
        /// </summary>
        public System.String car_company { get; set; }

        /// <summary>
        /// 车辆登记日期
        /// </summary>
        public System.DateTime? register_time { get; set; }

        /// <summary>
        /// 裸车价格
        /// </summary>
        public System.Double? car_money { get; set; }

        /// <summary>
        /// 改装公司
        /// </summary>
        public System.String refig_company { get; set; }

        /// <summary>
        /// 改装费
        /// </summary>
        public System.Double? refig_money { get; set; }

        /// <summary>
        /// 车辆购置税
        /// </summary>
        public System.Double? purchase_tax { get; set; }

        /// <summary>
        /// 挂牌费
        /// </summary>
        public System.Double? plate_money { get; set; }

        /// <summary>
        /// 保险id
        /// </summary>
        public System.String ins_id { get; set; }

        /// <summary>
        /// 年审id
        /// </summary>
        public System.Int32? av_id { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        public System.Int32? pri_user_id { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public System.String pri_user_name { get; set; }

        /// <summary>
        /// 图强imei
        /// </summary>
        public System.String tq_imei { get; set; }

        /// <summary>
        /// 里程数
        /// </summary>
        public System.Double? mileage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dep_id { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        public System.String img_url { get; set; }

        /// <summary>
        /// 是否删除 0否 1.是
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 交接时间
        /// </summary>
        public System.DateTime? connect_time { get; set; }
    }
}