

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 月计划详情表
    /// </summary>
    public class soc_month_plan_item
    {
        /// <summary>
        /// 月计划详情表
        /// </summary>
        public soc_month_plan_item()
        {
        }

        /// <summary>
        /// ID 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// (月计划表 month_plan)计划单号: MHMP201911001
        /// </summary>
        public System.String mp_code { get; set; }

        /// <summary>
        /// 计划号(唯一): MHMP20191100101
        ///(01号计划)
        /// </summary>
        public System.String plan_code { get; set; }

        /// <summary>
        /// 目标id
        /// </summary>
        public System.Int64? target_id { get; set; }

        /// <summary>
        /// 目标名称
        /// </summary>
        public System.String target_name { get; set; }

        /// <summary>
        /// 一级模块
        /// </summary>
        public System.String first_class { get; set; }

        /// <summary>
        /// 二级模块
        /// </summary>
        public System.String second_class { get; set; }

        /// <summary>
        /// 三级模块
        /// </summary>
        public System.String third_class { get; set; }

        /// <summary>
        /// 二级菜单合并数
        /// </summary>
        public System.Int32? sec_class_row { get; set; }

        /// <summary>
        /// 三级菜单合并数
        /// </summary>
        public System.Int32? thi_class_row { get; set; }

        /// <summary>
        /// 类型 1.管理 2.业务 3.其他
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 计划安排
        /// </summary>
        public System.String plan { get; set; }

        /// <summary>
        /// 是否重点工作 1.重点 0非重点
        /// </summary>
        public System.SByte? is_key_point { get; set; }

        /// <summary>
        /// 是否为绩效gs项
        /// </summary>
        public System.SByte? is_gs { get; set; }

        /// <summary>
        /// 结果定义
        /// </summary>
        public System.String desired_result { get; set; }

        /// <summary>
        /// 第一周
        /// </summary>
        public System.String w1 { get; set; }

        /// <summary>
        /// 第二周
        /// </summary>
        public System.String w2 { get; set; }

        /// <summary>
        /// 第三周
        /// </summary>
        public System.String w3 { get; set; }

        /// <summary>
        /// 第四周
        /// </summary>
        public System.String w4 { get; set; }

        /// <summary>
        /// 自罚承诺
        /// </summary>
        public System.String commitment { get; set; }

        /// <summary>
        /// 任务等级 
        ///1.不重要不紧急
        ///2.紧急不重要
        ///3.重要不紧急
        ///重要且紧急
        /// </summary>
        public System.SByte? task_level { get; set; }

        /// <summary>
        /// 完成情况: 0未开始 1完成 2未完成 3中止
        /// </summary>
        public System.SByte? state { get; set; }

        /// <summary>
        /// 完成日期
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
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public System.Int64 create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
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

        /// <summary>
        /// 何时显示 1.所有时间 2.增加 3.修改 4.追加
        /// </summary>
        public System.SByte? show_type { get; set; }

        /// <summary>
        /// 预计结束周
        /// </summary>
        public System.SByte? pgf_week { get; set; }

        /// <summary>
        /// 总裁指引Id
        /// </summary>
        public System.String pg_id { get; set; }
    }
}