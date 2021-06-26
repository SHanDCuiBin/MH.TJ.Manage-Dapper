

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 总裁指引总表
    /// </summary>
    public class soc_president_guide_main
    {
        /// <summary>
        /// 总裁指引总表
        /// </summary>
        public soc_president_guide_main()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 任务数量
        /// </summary>
        public System.Int32? pgm_task_num { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public System.Int32? pgm_finish_num { get; set; }

        /// <summary>
        /// 未完成数量
        /// </summary>
        public System.Int32? pgm_unfinish_num { get; set; }

        /// <summary>
        /// 总裁指引code
        /// </summary>
        public System.String mhpg_code { get; set; }

        /// <summary>
        /// 月度
        /// </summary>
        public System.String pgm_time { get; set; }

        /// <summary>
        /// 确认状态（1：未确定，2：已确定）
        /// </summary>
        public System.Int32? pgm_state { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String pgm_create { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? pgm_createtime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String pgm_mod { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? pgm_modtime { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public System.DateTime? pgm_verify { get; set; }

        /// <summary>
        /// 完成率
        /// </summary>
        public System.Double? pgm_finish_rate { get; set; }
    }
}