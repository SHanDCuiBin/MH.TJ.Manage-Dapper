

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 参检所在学校
    /// </summary>
    public class health_check_school
    {
        /// <summary>
        /// 参检所在学校
        /// </summary>
        public health_check_school()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 参检所在学校机构id号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 体检id号
        /// </summary>
        public System.String checkhealth_id { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        public System.String schoolname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String classname { get; set; }
    }
}