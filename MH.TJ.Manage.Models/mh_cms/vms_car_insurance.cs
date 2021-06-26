

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 车辆保险表
    /// </summary>
    public class vms_car_insurance
    {
        /// <summary>
        /// 车辆保险表
        /// </summary>
        public vms_car_insurance()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String plate_no { get; set; }

        /// <summary>
        /// 保险公司id
        /// </summary>
        public System.Int32? company_id { get; set; }

        /// <summary>
        /// 保险公司名称
        /// </summary>
        public System.String company_name { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public System.Int32? pri_user_id { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public System.String pri_user_name { get; set; }

        /// <summary>
        /// 保险金额
        /// </summary>
        public System.Double? money { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public System.String phone_num { get; set; }

        /// <summary>
        /// 保险公司联系人
        /// </summary>
        public System.String lxr { get; set; }

        /// <summary>
        /// 保险购买日期
        /// </summary>
        public System.DateTime? buy_date { get; set; }

        /// <summary>
        /// 保险购买人
        /// </summary>
        public System.Int32? buy_userid { get; set; }

        /// <summary>
        /// 保险开始日期
        /// </summary>
        public System.DateTime? start_date { get; set; }

        /// <summary>
        /// 保险结束日期
        /// </summary>
        public System.DateTime? end_date { get; set; }

        /// <summary>
        /// 险种
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 保险类型名称
        /// </summary>
        public System.String type_name { get; set; }

        /// <summary>
        /// 保单url
        /// </summary>
        public System.String bd_url { get; set; }

        /// <summary>
        /// 是否过期0正常1已过期
        /// </summary>
        public System.Int32 is_under_warranty { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 是否删除 0否 1.是
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 钉钉提醒时间
        /// </summary>
        public System.DateTime? ding_time { get; set; }

        /// <summary>
        /// 商业险费用
        /// </summary>
        public System.Double? business_money { get; set; }

        /// <summary>
        /// 交强险费用
        /// </summary>
        public System.Double? jqx_money { get; set; }

        /// <summary>
        /// 车船税费用
        /// </summary>
        public System.Double? transport_money { get; set; }

        /// <summary>
        /// 其他险费用
        /// </summary>
        public System.Double? other_money { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String note { get; set; }
    }
}