
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 西海岸糖尿病随访表
    /// </summary>
    public class tnbsf_xihaian
    {
        /// <summary>
        /// 西海岸糖尿病随访表
        /// </summary>
        public tnbsf_xihaian()
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
        /// 空腹血糖
        /// </summary>
        public System.Double? kfxt { get; set; }
    }
}