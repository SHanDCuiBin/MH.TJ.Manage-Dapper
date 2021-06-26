

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修记录表
    /// </summary>
    public class mms_maintenance_record
    {
        /// <summary>
        /// 维修记录表
        /// </summary>
        public mms_maintenance_record()
        {
        }

        /// <summary>
        /// Id uuid
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 维修工程师，创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 维修工程师姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public System.Int32? products_id { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public System.String number { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public System.Int32? employ_user_id { get; set; }

        /// <summary>
        /// 使用人姓名
        /// </summary>
        public System.String employ_user_name { get; set; }

        /// <summary>
        /// 维修日期
        /// </summary>
        public System.DateTime? maintenance_time { get; set; }

        /// <summary>
        /// 是否更换备件1.是2.不是
        /// </summary>
        public System.Int32? is_change { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 故障原因
        /// </summary>
        public System.String fault_msg { get; set; }

        /// <summary>
        /// 维修方法
        /// </summary>
        public System.String maintenance_method { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user { get; set; }

        /// <summary>
        /// 修改人姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}