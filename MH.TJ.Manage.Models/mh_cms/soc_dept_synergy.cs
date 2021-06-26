

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 运营管控周计划部门协同表
    /// </summary>
    public class soc_dept_synergy
    {
        /// <summary>
        /// 运营管控周计划部门协同表
        /// </summary>
        public soc_dept_synergy()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 周计划code
        /// </summary>
        public System.String wp_code { get; set; }

        /// <summary>
        /// 周计划开始日期
        /// </summary>
        public System.DateTime? start_time { get; set; }

        /// <summary>
        /// 显示序号
        /// </summary>
        public System.Int32 no { get; set; }

        /// <summary>
        /// type类型0部门协同
        /// </summary>
        public System.Int32 type { get; set; }

        /// <summary>
        /// 是否删除0正常1删除
        /// </summary>
        public System.Int32 is_delete { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public System.String item_name { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public System.String content { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.Int32? create_user_id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? create_time { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.Int32? update_user_id { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String update_user_name { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? update_time { get; set; }
    }
}