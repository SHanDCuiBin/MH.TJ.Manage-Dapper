

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 系统 菜单表
    /// </summary>
    public class sys_menu
    {
        /// <summary>
        /// 系统 菜单表
        /// </summary>
        public sys_menu()
        {
        }

        /// <summary>
        /// 主键id
        /// </summary>
        public System.Int64 id { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
        public System.String code { get; set; }

        /// <summary>
        /// 菜单父编号
        /// </summary>
        public System.String pcode { get; set; }

        /// <summary>
        /// 当前菜单的所有父菜单编号
        /// </summary>
        public System.String pcodes { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public System.String name { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        public System.String icon { get; set; }

        /// <summary>
        /// url地址
        /// </summary>
        public System.String url { get; set; }

        /// <summary>
        /// 菜单排序号
        /// </summary>
        public System.Int32? num { get; set; }

        /// <summary>
        /// 菜单层级
        /// </summary>
        public System.Int32? levels { get; set; }

        /// <summary>
        /// 是否是菜单（1：是  0：不是）
        /// </summary>
        public System.Int32? ismenu { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String tips { get; set; }

        /// <summary>
        /// 菜单状态 :  1:启用   0:不启用
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 是否打开:    1:打开   0:不打开
        /// </summary>
        public System.Int32? isopen { get; set; }
    }
}