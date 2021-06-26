
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 主要用药情况
    /// </summary>
    public class mh_jktj_medicine
    {
        /// <summary>
        /// 主要用药情况
        /// </summary>
        public mh_jktj_medicine()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String jktj_id { get; set; }

        /// <summary>
        /// 药物类型
        /// </summary>
        public System.String drug_type { get; set; }

        /// <summary>
        /// 药物名称
        /// </summary>
        public System.String drug_name { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public System.String drug_spname { get; set; }

        /// <summary>
        /// 用法
        /// </summary>
        public System.String drug_usage_code { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        public System.String consumption { get; set; }

        /// <summary>
        /// 用药时间
        /// </summary>
        public System.String medicationtime { get; set; }

        /// <summary>
        /// 服药依从性
        /// </summary>
        public System.String compliance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }
    }
}