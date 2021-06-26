

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 申请单出库表
    /// </summary>
    public class wms_application_out_warehouse
    {
        /// <summary>
        /// 申请单出库表
        /// </summary>
        public wms_application_out_warehouse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 出库单号
        /// </summary>
        public System.String out_code { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        public System.String apply_id { get; set; }

        /// <summary>
        /// 沐华编号（二维码）
        /// </summary>
        public System.String mh_code { get; set; }

        /// <summary>
        /// 耗材（机构号）或仓库号（设备）
        /// </summary>
        public System.String client_id { get; set; }

        /// <summary>
        /// 客户名字
        /// </summary>
        public System.String client_name { get; set; }

        /// <summary>
        /// 接收人id
        /// </summary>
        public System.String receiveer_id { get; set; }

        /// <summary>
        /// 接收人名字
        /// </summary>
        public System.String receiveer_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 确认人id
        /// </summary>
        public System.Int32? sure_user_id { get; set; }

        /// <summary>
        /// 确认人名字
        /// </summary>
        public System.String sure_user_name { get; set; }

        /// <summary>
        /// 类型 1 耗材 2 设备(弃用)
        /// </summary>
        public System.Int32? type { get; set; }
    }
}