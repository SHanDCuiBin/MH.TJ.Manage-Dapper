
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 非免疫规划预防接种史
    /// </summary>
    public class mh_jktj_immunization
    {
        /// <summary>
        /// 非免疫规划预防接种史
        /// </summary>
        public mh_jktj_immunization()
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
        /// 免疫  名称
        /// </summary>
        public System.String immune_name { get; set; }

        /// <summary>
        /// 接种时间
        /// </summary>
        public System.DateTime? immune_time { get; set; }

        /// <summary>
        /// 接种机构
        /// </summary>
        public System.String immune_mechanism { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }
    }
}