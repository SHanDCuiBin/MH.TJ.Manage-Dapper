

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 开票管理流程记录表
    /// </summary>
    public class cms_tj_out_ticket
    {
        /// <summary>
        /// 开票管理流程记录表
        /// </summary>
        public cms_tj_out_ticket()
        {
        }

        /// <summary>
        /// 主键，UUID
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 用户类型（0老客户 1新客户）
        /// </summary>
        public System.Int32? customer_type { get; set; }

        /// <summary>
        /// 销售人ID
        /// </summary>
        public System.Int32? seller_id { get; set; }

        /// <summary>
        /// 销售人姓名
        /// </summary>
        public System.String seller_name { get; set; }

        /// <summary>
        /// 机构类型（0院内 1院外）
        /// </summary>
        public System.Int32? org_type { get; set; }

        /// <summary>
        /// 机构服务状态(0进行中 1结束 2暂停)
        /// </summary>
        public System.Int32? org_state { get; set; }

        /// <summary>
        /// 上传确认的状态（0 还未开始分配 1已分配给主管 2已分配给工程师3已确认）
        /// </summary>
        public System.Int32? upload_state { get; set; }

        /// <summary>
        /// 上传确认的经理ID
        /// </summary>
        public System.Int32? upload_manager_id { get; set; }

        /// <summary>
        /// 上传确认的经理名称
        /// </summary>
        public System.String upload_manager_name { get; set; }

        /// <summary>
        /// 上传确认的工程师ID
        /// </summary>
        public System.Int32? upload_engid { get; set; }

        /// <summary>
        /// 上传确认的工程师Name
        /// </summary>
        public System.String upload_engname { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        public System.DateTime? service_starttime { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        public System.DateTime? service_endtime { get; set; }

        /// <summary>
        /// 打印报告份数
        /// </summary>
        public System.Int32? print_bg_number { get; set; }

        /// <summary>
        /// 打印档案份数
        /// </summary>
        public System.Int32? print_da_number { get; set; }

        /// <summary>
        /// 卫生院总打印数
        /// </summary>
        public System.Int32? wsy_total_print { get; set; }

        /// <summary>
        /// 休息天数
        /// </summary>
        public System.Int32? holiday { get; set; }

        /// <summary>
        /// 工作天数
        /// </summary>
        public System.Int32? workday { get; set; }

        /// <summary>
        /// 查体车数辆
        /// </summary>
        public System.String car_number { get; set; }

        /// <summary>
        /// 工程师数量
        /// </summary>
        public System.String eng_number { get; set; }

        /// <summary>
        /// 是否提供设备（0否 1是）
        /// </summary>
        public System.Int32? is_tgsb { get; set; }

        /// <summary>
        /// 是否提供驻厂（0否 1是）
        /// </summary>
        public System.Int32? is_eng_zc { get; set; }

        /// <summary>
        /// 是否试剂混用（0否 1是）
        /// </summary>
        public System.Int32? is_sjhy { get; set; }

        /// <summary>
        /// 开票确认人id
        /// </summary>
        public System.Int32? check_user_id { get; set; }

        /// <summary>
        /// 开票确认人姓名
        /// </summary>
        public System.String check_user_name { get; set; }

        /// <summary>
        /// 开票确认时间
        /// </summary>
        public System.DateTime? check_time { get; set; }

        /// <summary>
        /// 任务结束不开票原因
        /// </summary>
        public System.String msg { get; set; }
    }
}