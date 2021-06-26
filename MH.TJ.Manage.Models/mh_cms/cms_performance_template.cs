

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 绩效模板表
    /// </summary>
    public class cms_performance_template
    {
        /// <summary>
        /// 绩效模板表
        /// </summary>
        public cms_performance_template()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 number { get; set; }

        /// <summary>
        /// 上级id
        /// </summary>
        public System.Int32 parent_id { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public System.Int32? weight { get; set; }

        /// <summary>
        /// 权重最低占比
        /// </summary>
        public System.Int32 weight_min { get; set; }

        /// <summary>
        /// 权重最大占比
        /// </summary>
        public System.Int32? weight_max { get; set; }

        /// <summary>
        /// 工作目标
        /// </summary>
        public System.String job_objective { get; set; }

        /// <summary>
        /// 工作计划
        /// </summary>
        public System.String work_plan { get; set; }

        /// <summary>
        /// 评分标准
        /// </summary>
        public System.String scoring { get; set; }

        /// <summary>
        /// 考核项目
        /// </summary>
        public System.String project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime create_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? update_user_id { get; set; }
    }
}