

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 公卫平台账号信息表
    /// </summary>
    public class pub_health_account
    {
        /// <summary>
        /// 公卫平台账号信息表
        /// </summary>
        public pub_health_account()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 关联公卫平台基本信息表id
        /// </summary>
        public System.String base_id { get; set; }

        /// <summary>
        /// 机构编号id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 公卫平台账号
        /// </summary>
        public System.String account { get; set; }

        /// <summary>
        /// 公卫账号密码
        /// </summary>
        public System.String passsword { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public System.String contacts { get; set; }

        /// <summary>
        /// 联系人电话
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
        /// 是否可用  0不可用 1可用
        /// </summary>
        public System.Int32 enable { get; set; }

        /// <summary>
        /// 平台类型0公卫1.公卫接口2.家医
        /// </summary>
        public System.Int32 type { get; set; }
    }
}