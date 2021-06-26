

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_menu
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_menu()
        {
        }

        /// <summary>
        /// 菜单编码
        /// </summary>
        public System.Int32 Menuid { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public System.String Menuname { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public System.String path { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? Createtime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public System.String CreateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? Updatetime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public System.String UpdateUser { get; set; }

        /// <summary>
        /// 删除状态。0：未删除，1：已删除
        /// </summary>
        public System.Int32? DelFlag { get; set; }

        /// <summary>
        /// 启用状态。0：已启用，1：未启用
        /// </summary>
        public System.Int32? Status { get; set; }

        /// <summary>
        /// 上级菜单地址
        /// </summary>
        public System.Int32? ParentId { get; set; }

        /// <summary>
        /// 菜单类型（M目录 C菜单 F按钮）
        /// </summary>
        public System.String MenuLevel { get; set; }

        /// <summary>
        /// Layout ParentView 组件特殊处理
        /// </summary>
        public System.String component { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        public System.String perms { get; set; }

        /// <summary>
        /// 菜单排序
        /// </summary>
        public System.Int32? order_num { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public System.String icon { get; set; }

        /// <summary>
        /// 菜单显示状态（0显示 1隐藏）
        /// </summary>
        public System.Int32? visible { get; set; }

        /// <summary>
        /// 是否为外链（0是 1否）
        /// </summary>
        public System.Int32? isframe { get; set; }
    }
}