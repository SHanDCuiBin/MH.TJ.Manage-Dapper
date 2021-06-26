

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 机构与检验范围的关系信息表----健康体检  检验范围信息表    机构对应范围名称
    /// </summary>
    public class mh_jy_org_fwlist
    {
        /// <summary>
        /// 机构与检验范围的关系信息表----健康体检  检验范围信息表    机构对应范围名称
        /// </summary>
        public mh_jy_org_fwlist()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String fwls_id { get; set; }

        /// <summary>
        /// 体检类型   1 公卫健康体检   2  幼儿园健康体检     4  教师健康体检  
        /// </summary>
        public System.Int32 fwls_type { get; set; }

        /// <summary>
        ///  体检年份
        /// </summary>
        public System.Int32 fwls_year { get; set; }

        /// <summary>
        /// 范围模板名称
        /// </summary>
        public System.String fwls_name { get; set; }

        /// <summary>
        /// 启用状态    0  启用  1禁用
        /// </summary>
        public System.UInt32 fwls_enable { get; set; }

        /// <summary>
        /// 范围级别    1 共有模板范围     2 私有模板范围
        /// </summary>
        public System.Int32? fwls_level { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String fwls_org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String fwls_org_name { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String fwls_create_user_id { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public System.String fwls_create_user_name { get; set; }

        /// <summary>
        /// 创建时间 
        /// </summary>
        public System.DateTime? fwls_create_time { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String fwls_remark { get; set; }
    }
}