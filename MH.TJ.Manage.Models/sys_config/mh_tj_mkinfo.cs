

namespace MH.TJ.Manage.Models.sys_config
{
    /// <summary>
    /// 体检模块信息表--记录体检模块设置的信息
    /// </summary>
    public class mh_tj_mkinfo
    {
        /// <summary>
        /// 体检模块信息表--记录体检模块设置的信息
        /// </summary>
        public mh_tj_mkinfo()
        {
        }

        /// <summary>
        /// 模块编号
        /// </summary>
        public System.String mk_id { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 体检类型   1 老年人   2 幼儿园  3 学生  4 教师
        /// </summary>
        public System.String tj_type { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public System.Int32? year { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public System.String mk_name { get; set; }

        /// <summary>
        /// 模块显示内容  **,**,**
        /// </summary>
        public System.String mk_nr { get; set; }

        /// <summary>
        /// 模块级别    0 共有模块   1 私有模块
        /// </summary>
        public System.Int32? mk_level { get; set; }

        /// <summary>
        /// 模块启用状态       0 启用  1 禁用
        /// </summary>
        public System.Int32? mk_enable { get; set; }

        /// <summary>
        /// 模块上级名称     体检模块
        /// </summary>
        public System.String mk_parent { get; set; }

        /// <summary>
        /// 模块介绍
        /// </summary>
        public System.String mk_info { get; set; }

        /// <summary>
        /// 模块备注
        /// </summary>
        public System.String mk_remarl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_time { get; set; }
    }
}