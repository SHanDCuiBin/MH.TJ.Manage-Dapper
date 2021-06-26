

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 生化模板表
    /// </summary>
    public class cms_tj_shmb
    {
        /// <summary>
        /// 生化模板表
        /// </summary>
        public cms_tj_shmb()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 生化项目id
        /// </summary>
        public System.String sh_type { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public System.String create_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 模板状态 0.正常1.停用
        /// </summary>
        public System.Int32? state { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String update_id { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }

        /// <summary>
        /// 人员类型
        /// </summary>
        public System.Int32? type { get; set; }
    }
}