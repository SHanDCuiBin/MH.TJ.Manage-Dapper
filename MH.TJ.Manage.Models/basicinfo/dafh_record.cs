

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 档案复核记录表
    /// </summary>
    public class dafh_record
    {
        /// <summary>
        /// 档案复核记录表
        /// </summary>
        public dafh_record()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.TimeSpan? create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String fh_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String fh_content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 复核档案编号
        /// </summary>
        public System.String fhdabh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String sfz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String xm { get; set; }
    }
}