

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 绩效项目子表
    /// </summary>
    public class cms_performance_items
    {
        /// <summary>
        /// 绩效项目子表
        /// </summary>
        public cms_performance_items()
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
        /// 考核项目
        /// </summary>
        public System.String project { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32? no { get; set; }

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
        /// 权重
        /// </summary>
        public System.Int32? weight { get; set; }

        /// <summary>
        /// 部门协同发起部门
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 自评得分
        /// </summary>
        public System.Int32? zp_grade { get; set; }

        /// <summary>
        /// 领导评分
        /// </summary>
        public System.Int32? parent_grade { get; set; }

        /// <summary>
        /// 自我评价
        /// </summary>
        public System.String zp_valuate { get; set; }

        /// <summary>
        /// 领导评价
        /// </summary>
        public System.String parent_valuate { get; set; }

        /// <summary>
        /// 此项得分
        /// </summary>
        public System.Int32? grade { get; set; }

        /// <summary>
        /// 凭证
        /// </summary>
        public System.String voucher { get; set; }

        /// <summary>
        /// 备注，记录附加分删除后的perid，删除人删除时间等用于定位附加分丢失bug
        /// </summary>
        public System.String remark { get; set; }
    }
}