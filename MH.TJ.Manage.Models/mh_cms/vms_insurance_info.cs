

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 保险基本信息维护
    /// </summary>
    public class vms_insurance_info
    {
        /// <summary>
        /// 保险基本信息维护
        /// </summary>
        public vms_insurance_info()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 保险公司或险种名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 删除状态0.正常;1.删除
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 类型0公司名称1险种
        /// </summary>
        public System.Int32 type { get; set; }

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
    }
}