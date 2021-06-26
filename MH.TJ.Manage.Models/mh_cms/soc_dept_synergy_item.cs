

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 运营管控周计划部门协同表子表
    /// </summary>
    public class soc_dept_synergy_item
    {
        /// <summary>
        /// 运营管控周计划部门协同表子表
        /// </summary>
        public soc_dept_synergy_item()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 周计划部门协同或绩效部门协同表id
        /// </summary>
        public System.String pid { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public System.Int32? dept_id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public System.String dept_name { get; set; }

        /// <summary>
        /// 状态0未确认1已同意2已拒绝
        /// </summary>
        public System.Int32 state { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.Int32? confirm_user_id { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String confirm_user_name { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public System.DateTime? confirm_time { get; set; }
    }
}