

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    ///  B超、X光、心电图等模板表  --记录B超、X光、心电图等模板数据信息
    /// </summary>
    public class mh_tjjlmb
    {
        /// <summary>
        ///  B超、X光、心电图等模板表  --记录B超、X光、心电图等模板数据信息
        /// </summary>
        public mh_tjjlmb()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String jl_id { get; set; }

        /// <summary>
        /// 结论名称
        /// </summary>
        public System.String jl_xm { get; set; }

        /// <summary>
        /// 等级：1总分，2分项
        /// </summary>
        public System.String jl_level { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        public System.String parent_id { get; set; }

        /// <summary>
        /// 上级名称
        /// </summary>
        public System.String parent_name { get; set; }

        /// <summary>
        /// 部位
        /// </summary>
        public System.String jl_buwei { get; set; }

        /// <summary>
        /// 结论状态：1，正常，2：异常
        /// </summary>
        public System.String jl_flag { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public System.String jl_biaoti { get; set; }

        /// <summary>
        /// 结论
        /// </summary>
        public System.String jl_jielun { get; set; }

        /// <summary>
        /// 所见
        /// </summary>
        public System.String jl_suojian { get; set; }

        /// <summary>
        /// 指导
        /// </summary>
        public System.String jl_zhidao { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String jl_remark { get; set; }

        /// <summary>
        /// 结论机构号
        /// </summary>
        public System.String jl_org_id { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String jl_org_name { get; set; }

        /// <summary>
        /// 使用者ID号
        /// </summary>
        public System.String jl_user_id { get; set; }

        /// <summary>
        /// 使用者名称
        /// </summary>
        public System.String jl_user_name { get; set; }

        /// <summary>
        /// 是否删除 0未删除 1删除
        /// </summary>
        public System.String is_delete { get; set; }
    }
}