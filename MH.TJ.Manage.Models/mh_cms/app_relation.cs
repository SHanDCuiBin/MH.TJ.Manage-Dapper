

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// app 角色, 个人和菜单关联表
    /// </summary>
    public class app_relation
    {
        /// <summary>
        /// app 角色, 个人和菜单关联表
        /// </summary>
        public app_relation()
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
        public System.Int32? node_id { get; set; }

        /// <summary>
        /// 菜单类型 1.大图标 2. 快捷菜单 3. 权限
        /// </summary>
        public System.SByte menu_type { get; set; }

        /// <summary>
        /// 等级 1. 角色 2. 个人
        /// </summary>
        public System.SByte tier { get; set; }
    }
}