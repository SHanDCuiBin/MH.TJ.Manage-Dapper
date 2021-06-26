
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 西海岸高血压随访表
    /// </summary>
    public class gxysf_xihaian
    {
        /// <summary>
        /// 西海岸高血压随访表
        /// </summary>
        public gxysf_xihaian()
        {
        }

        /// <summary>
        /// 卫生院
        /// </summary>
        public System.String hospital { get; set; }

        /// <summary>
        /// 机构名
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public System.String id_card { get; set; }

        /// <summary>
        /// 随访日期
        /// </summary>
        public System.DateTime sfrq { get; set; }

        /// <summary>
        /// 收缩压
        /// </summary>
        public System.Double? ssy { get; set; }

        /// <summary>
        /// 舒张压
        /// </summary>
        public System.Double? szy { get; set; }
    }
}