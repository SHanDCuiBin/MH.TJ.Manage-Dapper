

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 公卫平台基本信息表
    /// </summary>
    public class platform_base
    {
        /// <summary>
        /// 公卫平台基本信息表
        /// </summary>
        public platform_base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 机构id  街道及以上机构
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 平台地址
        /// </summary>
        public System.String platform_url { get; set; }

        /// <summary>
        /// 平台开发商
        /// </summary>
        public System.String platform_developer { get; set; }

        /// <summary>
        /// 合作日期
        /// </summary>
        public System.DateTime? cooperate_date { get; set; }

        /// <summary>
        /// 公卫负责人
        /// </summary>
        public System.String leader { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String phone { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? create_date { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.String create_userid { get; set; }

        /// <summary>
        /// 是否可用  0不可用  1可用
        /// </summary>
        public System.Int32 enable { get; set; }

        /// <summary>
        /// 平台类型0公卫1.公卫接口2.家医
        /// </summary>
        public System.Int32 type { get; set; }
    }
}