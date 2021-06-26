

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 
    /// </summary>
    public class sys_log_operate
    {
        /// <summary>
        /// 
        /// </summary>
        public sys_log_operate()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime base_create_time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String base_creator_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 log_status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ip_address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ip_location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String log_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String business_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String execute_url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String execute_param { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String execute_result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? execute_time { get; set; }
    }
}