

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 设备检修报告表
    /// </summary>
    public class mms_equipment_inspection_report
    {
        /// <summary>
        /// 设备检修报告表
        /// </summary>
        public mms_equipment_inspection_report()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public System.Int32? employ_user_id { get; set; }

        /// <summary>
        /// 使用人姓名
        /// </summary>
        public System.String employ_user_name { get; set; }

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
        /// 创建人
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