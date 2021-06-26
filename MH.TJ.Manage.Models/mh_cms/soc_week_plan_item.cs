

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 周计划详情表
    /// </summary>
    public class soc_week_plan_item
    {
        /// <summary>
        /// 周计划详情表
        /// </summary>
        public soc_week_plan_item()
        {
        }

        /// <summary>
        /// ID 主键
        /// </summary>
        public System.UInt64 id { get; set; }

        /// <summary>
        /// (月计划详情表month_plan_item) 计划号: MHMP20191100101
        /// </summary>
        public System.String plan_code { get; set; }

        /// <summary>
        /// (周计划表week_plan)周计划单号:
        ///MHWP2019111001
        /// </summary>
        public System.String wp_code { get; set; }

        /// <summary>
        /// 计划号: MHWP201911100101
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        public System.Int64? target_id { get; set; }

        /// <summary>
        /// 类型 1.管理 2.业务 3.其他
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 计划安排
        /// </summary>
        public System.String plan { get; set; }

        /// <summary>
        /// 结果定义
        /// </summary>
        public System.String desired_result { get; set; }

        /// <summary>
        /// 自罚承诺
        /// </summary>
        public System.String commitment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String tue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String wed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String thu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String fri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sun { get; set; }

        /// <summary>
        /// 需要的资源支持
        /// </summary>
        public System.String resource_support { get; set; }

        /// <summary>
        /// 任务等级 
        ///5.不重要不紧急
        ///6.紧急不重要
        ///7.重要不紧急
        ///重要且紧急
        /// </summary>
        public System.SByte? task_level { get; set; }

        /// <summary>
        /// 完成情况: 0未开始 1完成 2未完成 3中止
        /// </summary>
        public System.SByte state { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public System.DateTime? finish_time { get; set; }

        /// <summary>
        /// 未完成原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 新措施
        /// </summary>
        public System.String new_plan { get; set; }

        /// <summary>
        /// 新承诺
        /// </summary>
        public System.String new_commitment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        public System.String files { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }
    }
}