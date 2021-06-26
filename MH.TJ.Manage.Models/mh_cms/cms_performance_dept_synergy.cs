

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 绩效管理部门协同
    /// </summary>
    public class cms_performance_dept_synergy
    {
        /// <summary>
        /// 绩效管理部门协同
        /// </summary>
        public cms_performance_dept_synergy()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 绩效表id
        /// </summary>
        public System.String performance_id { get; set; }

        /// <summary>
        /// 绩效月度
        /// </summary>
        public System.String month { get; set; }

        /// <summary>
        /// 发起人部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 显示序号
        /// </summary>
        public System.Int32 no { get; set; }

        /// <summary>
        /// 是否删除0正常1删除
        /// </summary>
        public System.Int32 is_delete { get; set; }

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
        /// 创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}