

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 数据详情表
    /// </summary>
    public class qcs_details
    {
        /// <summary>
        /// 数据详情表
        /// </summary>
        public qcs_details()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 数据来源表id
        /// </summary>
        public System.Int64? p_id { get; set; }

        /// <summary>
        /// 体检信息id
        /// </summary>
        public System.String tjid { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? tjrq { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public System.String barcode { get; set; }

        /// <summary>
        /// 查体信息id
        /// </summary>
        public System.String ctxx_id { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String task_id { get; set; }

        /// <summary>
        /// 查体结果类型：
        ///1 血检逻辑性
        ///2 尿检阳性率
        ///
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 1 3≤五大项<5；2 五大项=5；
        /// </summary>
        public System.Int32? flag { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? revision_time { get; set; }
    }
}