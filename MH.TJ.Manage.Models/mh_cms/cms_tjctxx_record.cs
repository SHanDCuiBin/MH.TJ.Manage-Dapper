

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 体检记录表，用于记录任务当天是否查体（已停止使用）
    /// </summary>
    public class cms_tjctxx_record
    {
        /// <summary>
        /// 体检记录表，用于记录任务当天是否查体（已停止使用）
        /// </summary>
        public cms_tjctxx_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime tjrq { get; set; }

        /// <summary>
        /// 状态，0正常1不查
        /// </summary>
        public System.Int32 flag { get; set; }

        /// <summary>
        /// 体检人数
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_date { get; set; }
    }
}