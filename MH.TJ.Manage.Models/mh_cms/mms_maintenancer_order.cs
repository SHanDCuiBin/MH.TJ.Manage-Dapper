

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 维修工单表
    /// </summary>
    public class mms_maintenancer_order
    {
        /// <summary>
        /// 维修工单表
        /// </summary>
        public mms_maintenancer_order()
        {
        }

        /// <summary>
        /// id
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 工单编码
        /// </summary>
        public System.String order_num { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String dept { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? user_id { get; set; }

        /// <summary>
        /// 维修类型 1：公司设备报修 2：个人报修 3。行政报修
        /// </summary>
        public System.Int32? type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? maintain_date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? create_time { get; set; }
    }
}