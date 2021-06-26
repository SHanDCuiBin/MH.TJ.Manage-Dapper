

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 幼儿园班级、预计体检人数表
    /// </summary>
    public class child_class_grade
    {
        /// <summary>
        /// 幼儿园班级、预计体检人数表
        /// </summary>
        public child_class_grade()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        public System.String grade_class { get; set; }

        /// <summary>
        /// 预计人数
        /// </summary>
        public System.Int32? expected_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}