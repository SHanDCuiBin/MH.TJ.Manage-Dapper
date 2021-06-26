

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 客户工单-客户评价表
    /// </summary>
    public class qcs_customer_evaluation
    {
        /// <summary>
        /// 客户工单-客户评价表
        /// </summary>
        public qcs_customer_evaluation()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 服务评星
        /// </summary>
        public System.Int32 service { get; set; }

        /// <summary>
        /// 客户建议
        /// </summary>
        public System.String proposal { get; set; }

        /// <summary>
        /// 服务态度评星
        /// </summary>
        public System.Int32? service_attitude { get; set; }

        /// <summary>
        /// 专业程度评星
        /// </summary>
        public System.Int32? professionally { get; set; }

        /// <summary>
        /// 打印上传评星
        /// </summary>
        public System.Int32? print_upload { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime create_time { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 评价状态（1.及时评价 2.延期评价）
        /// </summary>
        public System.Int32? flag { get; set; }
    }
}