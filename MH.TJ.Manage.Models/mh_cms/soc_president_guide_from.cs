

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 总裁指引从表
    /// </summary>
    public class soc_president_guide_from
    {
        /// <summary>
        /// 总裁指引从表
        /// </summary>
        public soc_president_guide_from()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? pgf_dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String pgf_dept_name { get; set; }

        /// <summary>
        /// 预计完成时间
        /// </summary>
        public System.String pgf_time { get; set; }

        /// <summary>
        /// 预计完成时间的周
        /// </summary>
        public System.Int32? pgf_week { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public System.Int32? pgf_level { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public System.String pgf_name { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        public System.String pgf_content { get; set; }

        /// <summary>
        /// 预期结果
        /// </summary>
        public System.String pgf_result { get; set; }

        /// <summary>
        /// 完成状态（1完成 2未完成 3中止）
        /// </summary>
        public System.Int32? pgf_state { get; set; }

        /// <summary>
        /// 删除标记(0：未删除，1：已删除)
        /// </summary>
        public System.Int32? del_flag { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String pgf_mod { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? pgf_modtime { get; set; }

        /// <summary>
        /// 月计划id
        /// </summary>
        public System.Int32? mp_id { get; set; }

        /// <summary>
        /// 总裁指引code
        /// </summary>
        public System.String pgf_code { get; set; }
    }
}