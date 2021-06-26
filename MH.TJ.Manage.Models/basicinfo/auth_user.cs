

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class auth_user
    {
        /// <summary>
        /// 
        /// </summary>
        public auth_user()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String real_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String telphone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }

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
        public System.String description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String doctor_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String parent_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String parent_user_name { get; set; }
    }
}