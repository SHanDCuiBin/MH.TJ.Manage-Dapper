

namespace MH.TJ.Manage.Models.basicinfo
{
    /// <summary>
    /// 疾病史
    /// </summary>
    public class rhr_medical_history
    {
        /// <summary>
        /// 疾病史
        /// </summary>
        public rhr_medical_history()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.UInt32 id { get; set; }

        /// <summary>
        /// 居民健康档案id
        /// </summary>
        public System.String rhr_id { get; set; }

        /// <summary>
        /// 疾病史代码
        /// </summary>
        public System.String medical_history { get; set; }

        /// <summary>
        /// 确诊时间
        /// </summary>
        public System.DateTime? diagnostic_time { get; set; }

        /// <summary>
        /// 附加信息(其他说明)
        /// </summary>
        public System.String additional_info { get; set; }

        /// <summary>
        /// 诊断单位
        /// </summary>
        public System.String diagnosis_of_the_unit { get; set; }

        /// <summary>
        /// 处理情况
        ///
        /// </summary>
        public System.String handling_information { get; set; }

        /// <summary>
        /// 转归情况
        ///
        /// </summary>
        public System.String outcome_is { get; set; }

        /// <summary>
        /// 创建者姓名
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 修改者姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 创建地区
        /// </summary>
        public System.String create_a_region { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? gmt_modified { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? gmt_create { get; set; }

        /// <summary>
        /// 分片id
        /// </summary>
        public System.String sharding_id { get; set; }

        /// <summary>
        /// 0为未删除1为已删除
        /// </summary>
        public System.UInt32? deleted { get; set; }
    }
}