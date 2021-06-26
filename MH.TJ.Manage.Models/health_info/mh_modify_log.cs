
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 数据修改日志主表
    /// </summary>
    public class mh_modify_log
    {
        /// <summary>
        /// 数据修改日志主表
        /// </summary>
        public mh_modify_log()
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
        /// 模块类型  
        ///采血时间：cxsj;
        ///尿机时间:  njsj;
        ///检查医生：jcys;
        ///尿检结果：njjg;
        ///生化范围：shlimit;
        ///血球范围：xqlimit;
        ///生化检验时间:shjyrq
        ///生化检验时间:xqjyrq
        /// </summary>
        public System.String mk_type { get; set; }

        /// <summary>
        /// 修改的字段  多个字段用","分割，且需与子表的数据顺序相同 例：字段1,字段2,字段3
        /// </summary>
        public System.String fields { get; set; }

        /// <summary>
        /// 工程师账号
        /// </summary>
        public System.String gc_user_id { get; set; }

        /// <summary>
        /// 修改人账号
        /// </summary>
        public System.String update_user_id { get; set; }

        /// <summary>
        /// 修改人姓名
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 数据更新原因
        /// </summary>
        public System.String reason { get; set; }

        /// <summary>
        /// 是否是批量修改  0：否；1：是；
        /// </summary>
        public System.String is_batck { get; set; }
    }
}