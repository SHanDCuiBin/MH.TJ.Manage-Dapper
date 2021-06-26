

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 任务管理表
    /// </summary>
    public class cms_task
    {
        /// <summary>
        /// 任务管理表
        /// </summary>
        public cms_task()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public System.String taskname { get; set; }

        /// <summary>
        /// 负责人id
        /// </summary>
        public System.String mainuserid { get; set; }

        /// <summary>
        /// 负责人名称
        /// </summary>
        public System.String mainusername { get; set; }

        /// <summary>
        /// 服务机构id
        /// </summary>
        public System.String orgid { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String orgname { get; set; }

        /// <summary>
        /// 状态 0 暂停  1开始  2结束 3未开始4作废
        /// </summary>
        public System.String status { get; set; }

        /// <summary>
        /// 任务周期
        /// </summary>
        public System.String task_cycle { get; set; }

        /// <summary>
        /// 任务周期名称
        /// </summary>
        public System.String task_cycle_name { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public System.DateTime? startdate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? enddate { get; set; }

        /// <summary>
        /// 预估结束日期
        /// </summary>
        public System.DateTime? preenddate { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createdate { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.String createuserid { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public System.DateTime? updatedate { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public System.String updatedserid { get; set; }

        /// <summary>
        /// 查体类型 1 老年人 2 儿童 幼儿园 3 中小学生 4 教师  5 职工 6  其他 
        /// </summary>
        public System.Int32 checktype { get; set; }

        /// <summary>
        /// 体检类型
        /// </summary>
        public System.String checktypename { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.String years { get; set; }

        /// <summary>
        /// 血检范围模板sys_config库mh_jy_org_fwlist表关联
        /// </summary>
        public System.String fwlx_id { get; set; }

        /// <summary>
        /// 血检范围模板名称
        /// </summary>
        public System.String fwlx_name { get; set; }

        /// <summary>
        /// 审核类型,字典表cmsTaskAuditType
        /// </summary>
        public System.String audit_type { get; set; }

        /// <summary>
        /// 审核类型名称
        /// </summary>
        public System.String audit_type_name { get; set; }

        /// <summary>
        /// 生化模板id
        /// </summary>
        public System.Int32? shmbid { get; set; }

        /// <summary>
        /// 生化type
        /// </summary>
        public System.String shtype { get; set; }

        /// <summary>
        /// 0院内  1院外
        /// </summary>
        public System.Int32 outhospital { get; set; }

        /// <summary>
        /// 是否用公司的耗材试剂 1.用 0不用
        /// </summary>
        public System.SByte use_agentia { get; set; }

        /// <summary>
        /// 绩效系数
        /// </summary>
        public System.Double ratio_num { get; set; }

        /// <summary>
        /// 备注（用于HR判断是哪种绩效系数）
        /// </summary>
        public System.String remarkcontent { get; set; }

        /// <summary>
        /// 数据处理负责人ID号
        /// </summary>
        public System.String data_owner { get; set; }

        /// <summary>
        /// 负责人绩效分配占比
        /// </summary>
        public System.Int32 ratio_bl { get; set; }

        /// <summary>
        /// 用户类型（0老客户 1新客户）
        /// </summary>
        public System.Int32? customer_type { get; set; }

        /// <summary>
        /// 是否提供设备（0否 1是）
        /// </summary>
        public System.Int32? is_tgsb { get; set; }

        /// <summary>
        /// 是否试剂混用（0否 1是）
        /// </summary>
        public System.Int32? is_sjhy { get; set; }

        /// <summary>
        /// 是否家医签约（0否 1是）
        /// </summary>
        public System.Int32 is_jyqy { get; set; }

        /// <summary>
        /// 开票记录id
        /// </summary>
        public System.String out_ticket_id { get; set; }
    }
}