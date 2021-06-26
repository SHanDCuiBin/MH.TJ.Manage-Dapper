

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 打印报告/档案等  模板管理
    /// </summary>
    public class mh_printtemplate
    {
        /// <summary>
        /// 打印报告/档案等  模板管理
        /// </summary>
        public mh_printtemplate()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String mb_name { get; set; }

        /// <summary>
        /// 老年人 1/ 幼儿园 2/中小学生 3
        /// </summary>
        public System.String mb_ry_type { get; set; }

        /// <summary>
        /// 模板类型 报告1、档案2、其他3
        /// </summary>
        public System.String mb_type { get; set; }

        /// <summary>
        /// 两年模板 2/一年模板 1 
        /// </summary>
        public System.String is_dnmb { get; set; }

        /// <summary>
        /// 模板地址
        /// </summary>
        public System.String mb_url { get; set; }

        /// <summary>
        /// 模板状态 未启用 0 ；启用1
        /// </summary>
        public System.String mb_state { get; set; }

        /// <summary>
        /// 模版的二维码
        /// </summary>
        public System.String ewm_url { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.String creation_userid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? creation_time { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public System.DateTime? upd_time { get; set; }

        /// <summary>
        /// 更新人id
        /// </summary>
        public System.String upd_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 是否是主模板 0不是主模板 1是主模板
        /// </summary>
        public System.Int32? is_main { get; set; }
    }
}