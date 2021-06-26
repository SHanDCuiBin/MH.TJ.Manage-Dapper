

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统 角色和菜单关联表
    /// </summary>
    public class sys_relation
    {
        /// <summary>
        /// 系统 角色和菜单关联表
        /// </summary>
        public sys_relation()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.Int32 id { get; set; }

        /// <summary>
        /// 菜单id
        /// </summary>
        public System.Int64? menuid { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public System.Int32? roleid { get; set; }
    }
}