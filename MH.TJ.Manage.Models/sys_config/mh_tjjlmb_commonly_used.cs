

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 体检结论模板  - 常用模板
    /// </summary>
    public class mh_tjjlmb_commonly_used
    {
        /// <summary>
        /// 体检结论模板  - 常用模板
        /// </summary>
        public mh_tjjlmb_commonly_used()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 通用模板的主键id
        /// </summary>
        public System.String mb_id { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 结论状态：1，正常，2：异常
        /// </summary>
        public System.String jl_flag { get; set; }
    }
}