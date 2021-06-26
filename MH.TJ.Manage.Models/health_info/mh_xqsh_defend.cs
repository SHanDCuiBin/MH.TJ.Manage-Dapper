
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 生化血球维护表
    /// </summary>
    public class mh_xqsh_defend
    {
        /// <summary>
        /// 生化血球维护表
        /// </summary>
        public mh_xqsh_defend()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 生化id
        /// </summary>
        public System.String sh_parid { get; set; }

        /// <summary>
        /// 血球id
        /// </summary>
        public System.String xq_parid { get; set; }

        /// <summary>
        /// 尿检id
        /// </summary>
        public System.String nj_parid { get; set; }

        /// <summary>
        /// 性别 1.男，2.女，0.未区分
        /// </summary>
        public System.String gender { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String createUser { get; set; }

        /// <summary>
        ///  创建时间
        /// </summary>
        public System.DateTime? createTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public System.String updateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? updateTime { get; set; }

        /// <summary>
        /// 是否使用，1：使用，0：失效
        /// </summary>
        public System.String isMake { get; set; }
    }
}