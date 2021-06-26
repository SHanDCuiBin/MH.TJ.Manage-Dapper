

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 【沐华健康体检管理系统】体检模块  信息表--引导页菜单
    /// </summary>
    public class mh_guide_menu
    {
        /// <summary>
        /// 【沐华健康体检管理系统】体检模块  信息表--引导页菜单
        /// </summary>
        public mh_guide_menu()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32 mk_id { get; set; }

        /// <summary>
        /// 上级机构简称
        /// </summary>
        public System.String parent_num { get; set; }

        /// <summary>
        /// 上级机构名称
        /// </summary>
        public System.String parent_name { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        public System.String mk_name { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public System.String mk_num { get; set; }

        /// <summary>
        /// 模板对应简称
        /// </summary>
        public System.String mk_bj { get; set; }

        /// <summary>
        /// 上级机构下对应的模块编号
        /// </summary>
        public System.String mk_sx { get; set; }

        /// <summary>
        /// 模块种类
        /// </summary>
        public System.String mk_image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String mk_info { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String applycationName { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public System.String mh_enable { get; set; }

        /// <summary>
        /// 模块种类
        /// </summary>
        public System.String mk_type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String mh_remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String download_url { get; set; }

        /// <summary>
        /// 升级包更新地址
        /// </summary>
        public System.String update_url { get; set; }

        /// <summary>
        /// 菜单类型（是否可下载）  0不可下载模块菜单  1需下载模块菜单
        /// </summary>
        public System.String menutype { get; set; }

        /// <summary>
        /// 可下载模块版本号
        /// </summary>
        public System.String version { get; set; }

        /// <summary>
        /// 0为所有类型设备都添加，1为汇总本添加，空为可删除
        /// </summary>
        public System.String deletable { get; set; }
    }
}