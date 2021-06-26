
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 家庭病床史
    /// </summary>
    public class mh_jktj_family_history
    {
        /// <summary>
        /// 家庭病床史
        /// </summary>
        public mh_jktj_family_history()
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
        /// 建床时间
        /// </summary>
        public System.DateTime? bedbuildingtime { get; set; }

        /// <summary>
        /// 撤床时间
        /// </summary>
        public System.DateTime? removebedtime { get; set; }

        /// <summary>
        /// 入院原因
        /// </summary>
        public System.String reasons { get; set; }

        /// <summary>
        /// 医疗机构及科室
        /// </summary>
        public System.String department { get; set; }

        /// <summary>
        /// 病案号
        /// </summary>
        public System.String medicalnum { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String remark { get; set; }
    }
}