

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 体检模块信息表--记录体检模块设置的信息
    /// </summary>
    public class mh_tjmk
    {
        /// <summary>
        /// 体检模块信息表--记录体检模块设置的信息
        /// </summary>
        public mh_tjmk()
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
    }
}