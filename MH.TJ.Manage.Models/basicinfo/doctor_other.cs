

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 家庭（责任）护士或者公共卫生医生
    /// </summary>
    public class doctor_other
    {
        /// <summary>
        /// 家庭（责任）护士或者公共卫生医生
        /// </summary>
        public doctor_other()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 团队id（如果其他地区需要关联则需要用到该字段）
        /// </summary>
        public System.String team_id { get; set; }

        /// <summary>
        /// 家医id
        /// </summary>
        public System.String doctor_id { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        public System.String doctor_name { get; set; }

        /// <summary>
        /// 医生类型，1家庭（责任）护士；2公共卫生医生
        /// </summary>
        public System.String doctor_type { get; set; }
    }
}